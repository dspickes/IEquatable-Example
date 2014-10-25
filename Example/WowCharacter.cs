using System;

namespace IEquatable.Example
{
    public class WowCharacter
    {
        public String Name { get; private set; }
        public String Server { get; private set; }

        public WowCharacter( String name, String server )
        {
            Name = name;
            Server = server;
        }
    }
}