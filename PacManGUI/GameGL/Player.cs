using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PacMan.GameGL;

namespace PacManGUI.GameGL
{
    class Player:GameObject
    {
        private int pHealth = 100;
        public Player(Image image, GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.CurrentCell = startCell;
        }

        protected int PHealth { get => pHealth; set => pHealth = value; }

        public void ResetHelth()
        {
            pHealth = 100;
        }
        public void AddPHealth(int inc)
        {
                        
        }

        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
            }
            return nextCell;
        }
    }
}
