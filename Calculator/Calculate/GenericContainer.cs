namespace MultiCalc
{
    class GenericContainer<T> : CalcForm
    {
        private T obj;

        public GenericContainer() { }
        public GenericContainer(T t)
        {
            obj = t;
        }
        public T getObj()
        {
            return obj;
        }
        public void setObj(T t)
        {
            obj = t;
        }
    }
}
