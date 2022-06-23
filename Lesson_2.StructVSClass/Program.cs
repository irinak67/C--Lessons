// See https://aka.ms/new-console-template for more information

StructPixel sp;
ClassPixel cp;
sp = new StructPixel(10, 20);
cp = new ClassPixel(100, 200);
MovePixelSP(sp);
MovePixelCP(cp);

static void MovePixelSP (StructPixel sp)
{
    sp.X++;
    sp.Y++;
}

static void MovePixelCP (ClassPixel cp)
{
    cp.x++;
    cp.y++;
}
struct StructPixel
{
    public int X;
    public int Y;
    public StructPixel(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}

class ClassPixel
{
    public int x;
    public int y;

    public ClassPixel (int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}