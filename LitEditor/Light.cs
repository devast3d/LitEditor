using System;

namespace LitEditor
{
    public struct Float3
    {
        public float X;
        public float Y;
        public float Z;

        public Float3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override bool Equals(object obj)
        {
            if (obj is Float3)
            {
                Float3 other = (Float3)obj;
                bool result = X == other.X && Y == other.Y && Z == other.Z;
                return result;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        public static bool operator ==(Float3 value0, Float3 value1)
        {
            return value0.Equals(value1);
        }

        public static bool operator !=(Float3 value0, Float3 value1)
        {
            return !value0.Equals(value1);
        }

        public static Float3 FromFileFormatPosition(int x, int y, int z)
        {
            Float3 result = new Float3();
			result.X = LightUtil.FromFileFormatPosition(x);
			result.Y = LightUtil.FromFileFormatPosition(y);
			result.Z = LightUtil.FromFileFormatPosition(z);
			return result;
        }

        public void ToFileFormatPosition(out int x, out int y, out int z)
        {
			x = LightUtil.ToFileFormatPosition(X);
			y = LightUtil.ToFileFormatPosition(Y);
			z = LightUtil.ToFileFormatPosition(Z);
        }

        public static Float3 FromFileFormatColor(int x, int y, int z)
        {
			Float3 result = new Float3();
			result.X = LightUtil.FromFileFormatColor(x);
			result.Y = LightUtil.FromFileFormatColor(y);
			result.Z = LightUtil.FromFileFormatColor(z);
			return result;
		}

        public void ToFileFormatColor(out int x, out int y, out int z)
        {
			x = LightUtil.ToFileFormatColor(X);
			y = LightUtil.ToFileFormatColor(Y);
			z = LightUtil.ToFileFormatColor(Z);
		}
    }

	[Flags]
	public enum LightBehaviour
	{
		None,
		Light,
		Shadow,
	}

	public enum LightType
	{
		Directional,
		Point,
		TruePoint
	}

	[Flags]
	public enum LightDomain
	{
		None,
		Furn,
		Base
	}

	public static class LightUtil
	{
		public static float FromFileFormatPosition(int value)
		{
			float result = value / 1024f;
			return result;
		}

		public static int ToFileFormatPosition(float value)
		{
			int result = (int)Math.Round(value * 1024, MidpointRounding.AwayFromZero);
			return result;
		}

		public static float FromFileFormatColor(int value)
		{
			float result = value / 256f;
			return result;
		}

		public static int ToFileFormatColor(float value)
		{
			int result = (int)Math.Round(value * 256, MidpointRounding.AwayFromZero);
			return result;
		}
	}
    
    public class Light
    {
        public event Action Changed;
        public event Action<Light> Removing;

        private bool _enabled;
        private Float3 _position;
        private LightBehaviour _behaviour;
		private LightType _type;
		private LightDomain _domain;

        private float _unknown;
        private Float3 _color;

		public bool ChangedEventEnabled { get; set; }

        public bool Enabled
        {
            get { return _enabled; }
            set
            {
                if (value != _enabled)
                {
                    _enabled = value;
                    FireChangedEvent();
                }
            }
        }

        public Float3 Position
        {
            get { return _position; }
            set
            {
                if (value != _position)
                {
                    _position = value;
                    FireChangedEvent();
                }
            }
        }

        public LightBehaviour Behaviour
        {
            get { return _behaviour; }
            set
            {
                if (value != _behaviour)
                {
                    _behaviour = value;
                    FireChangedEvent();
                }
            }
        }

		public bool IsShadow
		{
			get { return (_behaviour & LightBehaviour.Shadow) == LightBehaviour.Shadow; }
		}

		public bool IsLight
		{
			get { return (_behaviour & LightBehaviour.Light) == LightBehaviour.Light; }
		}

		public LightType Type
		{
			get { return _type; }
			set
			{
				if (value != _type)
				{
					_type = value;
					FireChangedEvent();
				}
			}
		}

		public LightDomain Domain
		{
			get { return _domain; }
			set
			{
				if (value != _domain)
				{
					_domain = value;
					FireChangedEvent();
				}
			}
		}

		public bool IsFurn
		{
			get { return (_domain & LightDomain.Furn) == LightDomain.Furn; }
		}

		public bool IsBase
		{
			get { return (_domain & LightDomain.Base) == LightDomain.Base; }
		}

		public float Unknown
        {
            get { return _unknown; }
            set
            {
                if (value != _unknown)
                {
                    _unknown = value;
                    FireChangedEvent();
                }
            }
        }
        
        public Float3 Color
        {
            get { return _color; }
            set
            {
                if (value != _color)
                {
                    _color = value;
                    FireChangedEvent();
                }
            }
        }
        
        public Light()
        {
            _enabled = true;
            _position = new Float3(0, 1, 0);
			_behaviour = LightBehaviour.None;
			_type = LightType.Directional;
			_domain = LightDomain.None;
            _unknown = 0;
            _color = new Float3(1, 1, 1);
        }

		public void SetFlags(uint value)
		{
			LightBehaviour behaviour = LightBehaviour.None;
			if ((value & 1) != 0)
			{
				behaviour |= LightBehaviour.Shadow;
			}
			if ((value & 2) != 0)
			{
				behaviour |= LightBehaviour.Light;
			}

			LightType type;
			if ((value & 4) != 0)
			{
				type = LightType.Directional;
			}
			else if ((value & 8) != 0)
			{
				type = LightType.TruePoint;
			}
			else
			{
				type = LightType.Point;
			}

			LightDomain domain = LightDomain.None;
			if ((value & 16) != 0)
			{
				domain |= LightDomain.Furn;
			}
			if ((value & 32) != 0)
			{
				domain |= LightDomain.Base;
			}

			_behaviour = behaviour;
			_type = type;
			_domain = domain;

		}

		public uint GetFlags()
		{
			uint result = 0;

			if ((_behaviour & LightBehaviour.Shadow) == LightBehaviour.Shadow)
			{
				result |= 1;
			}
			if ((_behaviour & LightBehaviour.Light) == LightBehaviour.Light)
			{
				result |= 2;
			}

			if (_type == LightType.Directional)
			{
				result |= 4;
			}
			else if (_type == LightType.TruePoint)
			{
				result |= 8;
			}

			if ((_domain & LightDomain.Furn) == LightDomain.Furn)
			{
				result |= 16;
			}
			if ((_domain & LightDomain.Base) == LightDomain.Base)
			{
				result |= 32;
			}

			return result;
		}

        public void RemoveFromProject()
        {
            if (Removing != null) Removing(this);
        }

        private void FireChangedEvent()
        {
            if (Changed != null && ChangedEventEnabled) Changed();
        }
    }
}
