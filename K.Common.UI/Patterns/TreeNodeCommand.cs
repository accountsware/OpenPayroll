using System.Windows.Forms;

namespace K.Common.UI.Patterns
{
    public class TreeNodeCommand : TreeNode
    {
        public TreeNodeCommand(string text, ICommand command)
            : base(text)
        {
            Command = command;
        }

        public TreeNodeCommand(string text, ICommand command, TreeNodeCommand[] node)
            : base(text, node)
        {
            Command = command;
        }

        public TreeNodeCommand(string text, ICommand command, int imageIndex)
            : base(text)
        {
            Command = command;
            ImageIndex = imageIndex;
            SelectedImageIndex = imageIndex;
        }

        public TreeNodeCommand(string text, ICommand command, int imageIndex, TreeNodeCommand[] node)
            : base(text, node)
        {
            Command = command;
            ImageIndex = imageIndex;
            SelectedImageIndex = imageIndex;
        }

        public ICommand Command { get; set; }
    }
}
