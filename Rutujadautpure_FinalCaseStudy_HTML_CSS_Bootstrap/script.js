document.getElementById("userForm").addEventListener("submit", function(e){
    e.preventDefault();

    let name = document.getElementById("name").value;
    let email = document.getElementById("email").value;

    if(name === "" || email === ""){
        alert("Please fill all details");
    } else {
        alert("Thank you for registering, " + name + "!");
    }
});
