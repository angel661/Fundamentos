using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SudokuProyect01
{
    public class SudokuCelda
    {
# region constructor
        public SudokuCelda()
        {
            position = new Point(1, 1);
            _value = 1;
        }
        public SudokuCelda(Point position)
        {
            this.position = position;
        }
        public SudokuCelda(Point position, int value)
            : this(position)
        {
            _value = value;
        }
        public SudokuCelda(int value) : this(new Point(1, 1), value)
        { }

        private Point position;
        public Point Position
        {
            get { return position; }
            set {
                if (value.X >= 1 && value.X <= 9)
                    if (value.Y >= 1 && value.Y <= 9)
                        position = value; }
        }

        public int Row
        {
            get { return this.position.Y; }
        }
        public int Column
        {
            get { return this.position.X; }
        }

        private int _value = 1;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value > 0 && value < 10)
                    _value = value;
                else
                    value = 1;
            }
        }

        internal object GetPossibleValues()
        {
            throw new NotImplementedException();
        }
    }
}
#endregion