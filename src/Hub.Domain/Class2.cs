using System;

namespace Hub.Domain
{
    public class Class2
    {
        public int Value { get; set; }
        public Entry Instance { get; set; }

        public string Method1()
        {
            return Instance.Method1();
        }

        public int Create(int a)
        {
            Value = a;
        }
    }
}