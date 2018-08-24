<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Demo1.aspx.cs" Inherits="Demo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Knockout page</title>
       <link href="https://fonts.googleapis.com/css?family=Bangers|Baloo+Bhai" rel="stylesheet" />
<link href="https://fonts.googleapis.com/css?family=VT323" rel="stylesheet" /> 
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
        
    <div class="boxed">
   <h1>Groceries</h1>
</div>
<div class="card mx-auto">
<table class="table">
   <thead>
      <th>Item</th>
      <th>Amount</th>
      <th>Remove?</th>
   </thead>
   <tbody data-bind="foreach: myCart">
     
      <td data-bind="text: groceryItem" class="style"></td>
      
      <td data-bind="text: groceryAmount" class="style"></td>
      <td><button class="remove" data-bind="click: function(data, event) { $root.removeItem(data); }"></button></td>
     
   </tbody>
 


<hr/>
</table>
</div>
<div class="box">
<label class="style3">Item:</label>
<input type="text" data-bind="value: groceryItem" class="style2"/>
<label class="style4"> Amount: </label>
<input type="text" class="textbox2" data-bind="value: itemAmount" class="style2"/>

   <button class="btn btn-sm-default" data-bind="click: addItem"><h4> ADD </h4> </button>
</div>


    
    <script src="Scripts/knockout-3.4.2.js"></script>
    <script type="text/javascript">


 function ViewModel() {
   var vm = this;
 
   this.groceryItem = ko.observable("");
   this.itemAmount = ko.observable("");
   this.myCart = ko.observableArray([]);
   this.addItem = function() {
      if (vm.groceryItem() != "") {
         var newItem = {
            "groceryItem": vm.groceryItem(),
            "groceryAmount": vm.itemAmount()
         };
         vm.myCart.push(newItem);
      }
   }
  this.removeItem = function(data) {
      vm.myCart.remove(function(item) {
         return (item.groceryItem == data.groceryItem && item.groceryAmount == data.groceryAmount);
      });
   }
}

ko.applyBindings(new ViewModel());


  
        </script>
</body>
</html>
