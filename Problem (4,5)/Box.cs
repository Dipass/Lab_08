using System;

internal class Box<T>
{
    public T box { get; set; }

    public Box(T boxs)
    {
        box = boxs;
    }

    public override string ToString()
    {
        return $"Output {typeof(T).FullName}:{box}";
    }

}