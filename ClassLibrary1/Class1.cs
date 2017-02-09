using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private static readonly object LockObject = new object();
        readonly List<int> _list = new List<int>();
        public void Run()
        {
            for (int i = 0; i < 1000; i++)
            {
                Task.Run(() =>
                {
                    lock (LockObject)
                    {
                        _list.Add(i);
                        if (_list.Count >= 50)
                        {
                            Class2.DoThings(_list);
                            _list.Clear();
                        }
                    }
                });
            }
        }
    }

    public class Class2
    {
        public static void DoThings(List<int> list)
        {
            List<int> copiedList = new List<int>();
            foreach (var item in list)
            {
                copiedList.Add(item);
            }
        }
    }
}
