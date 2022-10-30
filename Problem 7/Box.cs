using System;

class Box<T> where T : IComparable<T>
{
    private T[] masiv;
    private int _length;

    public Box(int length)
    {
        _length = length;
    }
    public T GetT
    {
        get { return masiv[_length]; }
        set { masiv[_length] = value; }
    }
    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public void Add(T news)
    {
        masiv[_length] = news;
        _length++;
    }

    public bool Contains(T for_check)
    {
        for (int i = 0; i < _length; i++)
        {
            if (masiv[i].Equals(for_check))
            {
                return true;
            }
        }
        return false;
    }
    public void Swap(int initial, int last)
    {
        T start = masiv[initial];
        masiv[initial] = masiv[last];
        masiv[last] = start;
    }

    public int Greater(T for_check)
    {
        int check = 0;
        for (int i = 0; i < _length; i++)
        {
            if (masiv[i].CompareTo(for_check) > 0)
            {
                check++;
            }
        }
        return check;
    }
    public T Max()
    {
        T max = masiv[0];
        for (int i = 0; i < _length; i++)
        {
            if (masiv[i].CompareTo(max) > 0)
            {
                max = masiv[i];
            }
        }
        return max;
    }

    public T Min()
    {
        T min = masiv[0];
        for (int i = 0; i < _length; i++)
        {
            if (masiv[i].CompareTo(min) < 0)
            {
                min = masiv[i];
            }
        }
        return min;
    }

    public void Print()
    {
        for (int i = 0; i < _length; i++)
        {
            Console.WriteLine($"Your masiv: {masiv[i]}");
        }
    }
}