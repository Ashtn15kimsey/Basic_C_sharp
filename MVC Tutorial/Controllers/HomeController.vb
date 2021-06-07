Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Random Rnd() = New Random(10)
        var num = Rnd.Next();


        If (num > 20000) Then{
            Return }







            Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
