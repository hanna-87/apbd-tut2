﻿namespace Tutorial2.Inheritance;

public class A: IMyInterface
{
    public string Name { get; set; }

    public A(string name)
    {
        Name = name;
    }

    public virtual int NewMethod() => 1;
    

}