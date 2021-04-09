//Traitement envoie du formulaire



$("#formVille").submit(function (e) {
    //blocage du formulaire 
    e.preventDefault();
    //recuperation du libele 
    var champLib = $("#lib").val();
    let Ville = {};
    Ville.Lib = champLib;
    //console.log(JSON.stringify(Ville))
    //Utilisation d'AJAX
    $.ajax({
        url: "/Ville/Creates",
        type :"POST", 
        contentType: "application/json",
        datatype: "json",
        data: JSON.stringify(Ville),
        success: function (data) {
            console.log(data);
        }
    });
});