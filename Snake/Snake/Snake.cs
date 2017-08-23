using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction) {
            pline = new List<Point>();
            direction = _direction;
            for (int i = 0; i < length; i++) {
                Point p = new Point(tail);
                p.Move(i, direction);
                pline.Add(p);
            }
        }

        internal void Move() {
            Point tail = pline.First();
            pline.Remove(tail);
            Point head = GetNextPoint();
            pline.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint() {
            Point head = pline.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail() {
			var head = pline.Last();
			for(int i = 0; i<pline.Count - 2; i++ )
			{
				if (head.IsHit(pline[i] ) )
					return true;
			}
			return false;
		}

        internal void HandleKey(ConsoleKey key) {
            switch (key) {
                case ConsoleKey.LeftArrow: {direction = Direction.LEFT; break;}
                case ConsoleKey.RightArrow: { direction = Direction.RIGHT; break; }
                case ConsoleKey.UpArrow: { direction = Direction.UP; break; }
                case ConsoleKey.DownArrow: { direction = Direction.DOWN; break; }
            }
        }
        internal bool Eat(Point food) {
            Point head = GetNextPoint();
            if (head.IsHit(food)) {
                food.sym = head.sym;
                pline.Add(food);
                food.Draw();
                return true;
            }
            else
                return false;
        }
    }
}
