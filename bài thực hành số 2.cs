//bai 3
class Queue
{
    private int dau, cuoi;
    private int[] q;
    public Queue()
    {
        dau = cuoi = 0;
        q = new int[20];
    }
    public Queue(int n)
    {
        dau = cuoi = 0;
        q = new int[n];

    }
    public bool isFull()
    {
        return cuoi >= q.Length - 1;
    }
    public bool isEmpty()
    {
        return dau == 0;
    }
    public void Push(int x)
    {
        if (isFull()) Console.WriteLine("Stack day");
        else
        {
            cuoi++;
            q[cuoi] = x;
        }
    }
    public int Pop()
    {
        if (isEmpty()) throw new Exception("Stack rong");
        else
        {
            int x = q[dau];
            dau--;
            return x;
        }
    }
}
}

//bai 4
class DATHUC
{
    private int n;
    private int[] a;
    public DATHUC()
    {
        n = 0; a = new int[0];
    }
    public DATHUC(int n)
    {
        this.n = n;
        a = new int[n];
    }
    public void Nhap()
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap a[{0}]=", i);
            a[i] = int.Parse(Console.ReadLine());
        }
    }
    public void Hien()
    {
        for (int i = 0; i < n; i++)
            Console.Write("{0}\n", a[i]);
        Console.WriteLine();
    }
    public DATHUC Tong(DATHUC T2)
    {
        if (this.n == T2.n)
        {
            DATHUC t = new DATHUC(this.n);
            for (int i = 0; i < n; i++)

                t.a[i] = this.a[i] + T2.a[i];
            return t;
        }
        else return null;
    }
    public DATHUC Hieu(DATHUC T2)
    {
        if (this.n == T2.n)
        {
            DATHUC t = new DATHUC(this.n);
            for (int i = 0; i < n; i++)

                t.a[i] = this.a[i] - T2.a[i];
            return t;
        }
        else return null;
    }

}

// bai 5
class Data
{
    private int day, month, year;
    public Data(DateTime dt)
    {
        day = dt.Day;
        month = dt.Month;
        year = dt.Year;
    }
    public void Hien()
    {
        Console.WriteLine("{0}/{1}/{2}", month, day, year);
    }