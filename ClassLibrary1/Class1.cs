using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        readonly SynchronizedCollection<int> _list = new SynchronizedCollection<int>();
        public void Run()
        {
            for (int i = 0; i < 1000; i++)
            {
                Task.Run(() =>
                {
                    _list.Add(i);
                    if (_list.Count >= 50)
                    {
                        Class2.DoThings(_list.ToList());
                        _list.Clear();
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
