Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors

Public Class NumPadForm
    Private keysGroup As SvgImageItem
    Public Sub New()
        InitializeComponent()
        keysGroup = svgImageBox1.FindItemById("keys")
        For Each key In keysGroup.Items
            Dim keyText = key.FindDescendantById($"txt_{key.Id}")
            keyText.Text = key.Id.ToUpper()
            keyText.Appearance.Hovered.FillColor = DXSkinColors.IconColors.White
            keyText.Appearance.Pressed.FillColor = DXSkinColors.IconColors.White
            key.Appearance.Hovered.FillColor = DXSkinColors.IconColors.Blue
            key.Appearance.Pressed.FillColor = DXSkinColors.IconColors.Black
        Next
    End Sub
    Sub OnQueryUniqueItemId(ByVal sender As Object, ByVal e As QueryUniqueItemIdEventArgs) Handles svgImageBox1.QueryUniqueItemId
        e.Id = $"{e.Id}_{e.UseElementId}"
    End Sub
    Sub OnQueryHoveredItem(ByVal sender As Object, ByVal e As SvgImageQueryHoveredItemEventArgs) Handles svgImageBox1.QueryHoveredItem
        ' Hover the entire key item
        e.HoveredItem = GetKeyItem(e.HitItems.FirstOrDefault())
    End Sub
    Sub OnItemPress(ByVal sender As Object, ByVal e As SvgImageItemEventArgs) Handles svgImageBox1.ItemPress
        ' do something 
        SendKeys.Send(e.Item.Id)
    End Sub
    Function GetKeyItem(ByVal item As SvgImageItem) As SvgImageItem
        If item Is Nothing Then Return Nothing
        If item.IsGroup AndAlso item.Parent Is keysGroup Then Return item
        Return item?.FindAncestor(Function(x) x.IsGroup AndAlso x.Parent Is keysGroup)
    End Function
End Class