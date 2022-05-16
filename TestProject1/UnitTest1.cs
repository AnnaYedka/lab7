using Xunit;
using lab7;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Matrix a = new Matrix(2, 3, 3, 4);
        Assert.Equal("(2, 3, 3, 4)", a.ToString());
    }

    [Fact]
    public void Test2()
    {
        Matrix a = new Matrix(2, 3, 3, 4);
        Matrix b = new Matrix(5, 6, 9, -1);
        
        Assert.Equal("(7, 9, 12, 3)", (a + b).ToString());
    }
    
    [Fact]
    public void Test3()
    {
        Matrix a = new Matrix(2, 3, 3, 4);
        Matrix b = new Matrix(5, 6, 9, -1);
        
        Assert.Equal("(-3, -3, -6, 5)", (a - b).ToString());
    }
    
    [Fact]
    public void Test4()
    {
        Matrix a = new Matrix(2, 3, 3, 4);
        Matrix b = new Matrix(5, 6, 9, -1);
        
        Assert.Equal("(37, 9, 51, 14)", (a * b).ToString());
    }
    
    [Fact]
    public void Test5()
    {
        Matrix a = new Matrix(2, 3, 3, 4);

        Assert.Equal("(10, 15, 15, 20)", (a * 5).ToString());
    }
    
    [Fact]
    public void Test6()
    {
        Matrix b = new Matrix(5, 6, 9, -1);
        
        Assert.Equal("(2, 3, 4, 0)", (b / 2).ToString());
    }
    
    [Fact]
    public void Test7()
    {
        Matrix a = new Matrix(2, 3, 3, 4);

        Assert.Equal(-1, (int) a);
    }
    
    [Fact]
    public void Test9()
    {
        Matrix a = new Matrix(2, 3, 3, 4);
        Matrix b = new Matrix(5, 6, 9, -1);
        
        Assert.False(a == b);
    }
    [Fact]
    public void Test10()
    {
        Matrix a = new Matrix(2, 3, 3, 4);
        Matrix b = new Matrix(2, 3, 3, 4);
        
        Assert.True(a == b);
    }
    
    [Fact]
    public void Test11()
    {
        Matrix a = new Matrix(2, 3, 3, 4);
        Matrix b = new Matrix(5, 6, 9, -1);
        
        Assert.True(a != b);
    }

    [Fact]
    public void Test12()
    {
        Matrix a = new Matrix(2, 3, 3, 4);
        Matrix b = new Matrix(2, 3, 3, 4);
        
        Assert.False(a != b);
    }
}