namespace lab7;

public class Matrix
{
    private int[,] matrix;

    public Matrix()
    {
        matrix = new int[2, 2];
    }

    public Matrix(int a, int b, int c, int d)
    {
        matrix = new int[2, 2];
        matrix[0, 0] = a;
        matrix[0, 1] = b;
        matrix[1, 0] = c;
        matrix[1, 1] = d;
    }

    public int this[int row, int column]
    {
        get
        {
            if ((row == 1 || row == 0) && (column == 0 || column == 1))
                return matrix[row, column];
            Console.WriteLine("invalid index");
            return 0;
        }
        set
        {
            if ((row == 1 || row == 0) && (column == 0 || column == 1))
                matrix[row, column] = value;
            else
            {
                Console.WriteLine("invalid index");
            }
        }
    }

    public static Matrix operator +(Matrix one, Matrix two)
    {
        Matrix temp = new Matrix();
        temp[0, 0] = one[0, 0] + two[0, 0];
        temp[0, 1] = one[0, 1] + two[0, 1];
        temp[1, 0] = one[1, 0] + two[1, 0];
        temp[1, 1] = one[1, 1] + two[1, 1];
        return temp;
    }
    public static Matrix operator -(Matrix one, Matrix two)
    {
        Matrix temp = new Matrix();
        temp[0, 0] = one[0, 0] - two[0, 0];
        temp[0, 1] = one[0, 1] - two[0, 1];
        temp[1, 0] = one[1, 0] - two[1, 0];
        temp[1, 1] = one[1, 1] - two[1, 1];
        return temp;
    }

    public static Matrix operator ++(Matrix one)
    {
        one[0, 0]++;
        one[0, 1]++;
        one[1, 0]++;
        one[1, 1]++;
        return one;
    }
    
    public static Matrix operator --(Matrix one)
    {
        one[0, 0]--;
        one[0, 1]--;
        one[1, 0]--;
        one[1, 1]--;
        return one;
    }

    public static Matrix operator *(Matrix one, Matrix two)
    {
        Matrix temp = new Matrix();
        temp[0, 0] = one[0, 0] * two[0, 0] + one[0, 1] * two[1, 0];
        temp[0, 1] = one[0, 0] * two[0, 1] + one[0, 1] * two[1, 1];
        temp[1, 0] = one[1, 0] * two[0, 0] + one[1, 1] * two[1, 0];
        temp[1, 1] = one[1, 0] * two[0, 1] + one[1, 1] * two[1, 1];
        return temp;
    }

    public static Matrix operator *(Matrix one, int val)
    {
        Matrix temp = new Matrix();
        temp[0, 0] = one[0, 0] * val;
        temp[0, 1] = one[0, 1] * val;
        temp[1, 0] = one[1, 0] * val;
        temp[1, 1] = one[1, 1] * val;
        return temp;
    }

    public static Matrix operator /(Matrix one, int val)
    {
        Matrix temp = new Matrix();
        temp[0, 0] = one[0, 0] / val;
        temp[0, 1] = one[0, 1] / val;
        temp[1, 0] = one[1, 0] / val;
        temp[1, 1] = one[1, 1] / val;
        return temp;
    }

    public static bool operator ==(Matrix one, Matrix two)
    {
        return one[0, 0] == two[0, 0] && one[1, 0] == two[1, 0] && one[0, 1] == two[0, 1] && one[1, 1] == two[1, 1];
    }

    public static bool operator !=(Matrix one, Matrix two)
    {
        return one[0, 0] != two[0, 0] && one[1, 0] != two[1, 0] && one[0, 1] != two[0, 1] && one[1, 1] != two[1, 1];
    }
    
    public static bool operator true(Matrix a)
    {
        return a[0, 0] * a[1, 1] - a[1, 0] * a[0, 1] != 0;
    }

    public static bool operator false(Matrix a)
    {
        return a[0, 0] * a[1, 1] - a[1, 0] * a[0, 1] == 0;
    }

    public static explicit operator int(Matrix a)
    {
        return a[0, 0] * a[1, 1] - a[1, 0] * a[0, 1];
    }

    public static explicit operator Matrix(int a)
    {
        Matrix temp = new Matrix();
        temp[0, 0] = a;
        temp[0, 1] = 0;
        temp[1, 0] = 0;
        temp[1, 1] = 1;
        return temp;
    }

    public override string ToString()
    {
        return "(" + matrix[0, 0] + ", " + matrix[0, 1] + ", " + matrix[1, 0] + ", " + matrix[1, 1] + ")";
    }
}