using System.Runtime.CompilerServices;
using Math;
namespace Mathoperation;

public class Complex
{
    private int real;
    private int imaginary;
    public Complex() //This is constructor (Class and constructor name shoud be same)

    {
        this.real = 9;
        this.imaginary = 6;
   } 
    public void SetReal(int real)
    {
        this.real = real;
    }
    public void SetImaginary(int imaginary)
    {
        this.imaginary = imaginary;
    }
    public int GetReal()
    {
        return this.real;

    }
    public int GetImaginary()
    {
        return this.imaginary;
    }

    
}
