using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace KeysInteractionSample {
    public partial class NumPadForm : XtraForm {
        SvgImageItem keysGroup;
        public NumPadForm() {
            InitializeComponent();
            keysGroup = svgImageBox1.FindItemById("keys");
            foreach(var key in keysGroup.Items) {
                var keyText = key.FindDescendantById($"txt_{key.Id}");
                keyText.Text = key.Id.ToUpper();
                keyText.Appearance.Hovered.FillColor = DXSkinColors.IconColors.White;
                keyText.Appearance.Pressed.FillColor = DXSkinColors.IconColors.White;
                key.Appearance.Hovered.FillColor = DXSkinColors.IconColors.Blue;
                key.Appearance.Pressed.FillColor = DXSkinColors.IconColors.Black;
            }
        }
        void OnQueryUniqueItemId(object sender, QueryUniqueItemIdEventArgs e) {
            e.Id = $"{e.Id}_{e.UseElementId}";
        }
        void OnQueryHoveredItem(object sender, SvgImageQueryHoveredItemEventArgs e) {
            // Hover the entire key item
            e.HoveredItem = GetKeyItem(e.HitItems.FirstOrDefault());
        }
        void OnItemPress(object sender, SvgImageItemEventArgs e) {
            /* do something */
            SendKeys.Send(e.Item.Id);
        }
        SvgImageItem GetKeyItem(SvgImageItem item) {
            if(item == null)
                return null;
            if(item.IsGroup && item.Parent == keysGroup)
                return item;
            return item?.FindAncestor(x => x.IsGroup && x.Parent == keysGroup);
        }
    }
}