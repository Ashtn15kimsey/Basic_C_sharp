Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = " contact page - The Tech Academy"

        Return View()
    End Function

    Function Instructor() As ActionResult
        Return View()

    End Function

    Function Instructor(int id) As ActionResult
        ViewBag.ID = id
        Return View()
    End Function





End Class
