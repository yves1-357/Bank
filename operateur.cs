// Vérifier qu'un compte bancaire BBAN est valide et afficher le résultat dans la console.
// (Il est valide si le modulo des 10 premiers
// chiffres par 97 donne les 2 derniers ou ils valent 97 s'il vaut 0).
//Exemple valide : 539007547034

/*
Console.WriteLine("entre BBan");
var bbn = Console.ReadLine();
Console.WriteLine(bban?.Length == 12 && long.TryParse(bban[..10], out var num)
&&((num % 97)).ToString("00") == bban[10..] || (num % 97 == 0 && bban[10..] == "97"))
?"valide": "invalid");
*/