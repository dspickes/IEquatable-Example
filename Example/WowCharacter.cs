using System;

namespace IEquatable.Example
{
    public sealed class WowCharacter : IEquatable<WowCharacter>
    {
        public String Name { get; private set; }
        public String Server { get; private set; }

        public WowCharacter( String name, String server )
        {
            Name = name;
            Server = server;
        }

        #region IEquatable
        public Boolean Equals( WowCharacter other )
        {
            throw new NotImplementedException();
        }

        public override Boolean Equals( Object obj )
        {
            throw new NotImplementedException();
        }

        public override Int32 GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static Boolean operator ==( WowCharacter first, WowCharacter second )
        {
            return true;
        }

        public static Boolean operator !=( WowCharacter first, WowCharacter second )
        {
            return false;
        }
        #endregion
    }
}