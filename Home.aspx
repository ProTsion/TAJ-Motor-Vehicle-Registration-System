<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="IdentityFramework.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-white jumbotron-image shadow" style="background-image: url(../Images/Carpic.jpg); background-repeat: inherit;">
        
        <div class="container" style="color:white">
            <h1>Tax Administrator Jamaica </h1>
            
            <hr class="my-4"> 
            <h2> Redefining the way you Register your vehicle </h2>
        </div>
    </div>

    <center>
    <div class="row placeholders">
            <div class="col-xs-8 col-sm-4 placeholder">
                <a href="../Worker/Fitness.aspx">
                    <img src="Images/fitness.jpg" width="200" height="200" class="img-responsive" alt="Generic placeholder thumbnail">
                </a>
                <h4>Add / update Fitness</h4>
            </div>

            <div class="col-xs-8 col-sm-4 placeholder">
                <a href="../Worker/Insurance.aspx">
                    <img src="Images/insurance.jpg" width="200" height="200" class="img-responsive" alt="Generic placeholder thumbnail">
                </a>
                 <h4>Add / update Insurance</h4>
                
            </div>

            <div class="col-xs-8 col-sm-4 placeholder">
                <a href="../User/Registration.aspx">
                    <img src="Images/registration.png" width="200" height="200" class="img-responsive" alt="Generic placeholder thumbnail">
                </a>
              <h4>Add / update Registration</h4>
                 
            </div>

            
          </div>
        </center>


</asp:Content>
