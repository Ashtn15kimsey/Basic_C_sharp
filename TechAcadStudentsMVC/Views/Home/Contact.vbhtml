@Code
    ViewData("Title") = "Talk to us"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>

<address>
    310 SW 4th Ave Suit 200<br />
    Portland, OR 97204<br />
    United States<br />
    <abbr title="Phone">P:</abbr>
    503-206-6915
</address>

<address>
    <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
</address>

<smaal>
  Contact Information Last Update: @DateTime.Now

</smaal>
