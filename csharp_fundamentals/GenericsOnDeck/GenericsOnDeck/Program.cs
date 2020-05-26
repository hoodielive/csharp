using System;

namespace GenericsOnDeck
{
    class Program
    {
        private int genericMemberVariable;

        public myGenericClass(int value)
        {
            genericMemberVariable = value;
        }

        public int genericMethod(int genericParameter)
        {
            Console.WriteLine("Parameter type:  {0}, value: {1} ", typeof(int).ToString(), genericParameter);
            Console.WriteLine("Parameter type:  {0}, value: {1} ", typeof(int).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }
    }
    
    public int genericProperty { get; set; }
}