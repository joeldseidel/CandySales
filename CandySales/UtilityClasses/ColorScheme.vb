Public Class ColorScheme
    Public primaryColor As Color
    Public secondaryColor As Color
    Sub New(primary() As Integer, secondary() As Integer)
        primaryColor = Color.FromArgb(primary(0), primary(1), primary(2))
        secondaryColor = Color.FromArgb(secondary(0), secondary(2), secondary(3))
    End Sub
    Sub New(primary As Color, secondary As Color)
        primaryColor = primary
        secondaryColor = secondary
    End Sub
    Sub New()
        primaryColor = Color.FromKnownColor(KnownColor.Control)
        secondaryColor = Color.FromKnownColor(KnownColor.Black)
    End Sub
End Class