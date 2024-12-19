// Création d'une instance de la classe Utilisateur avec des données différentes
Utilisateur utilisateur = new Utilisateur("Marie", "Durand", "azerty123", "marie.durand@example.com");

// Mise à jour de la propriété Nom
utilisateur.nom = "Test";

// Affichage de la propriété Nom
Console.WriteLine(utilisateur.nom);

// Définition de la classe Utilisateur
public class Utilisateur {
    // Propriétés auto-implémentées
    public string? Nom { get; set; } 
    public string? Prenom { get; set; }
    public string? Mdp { get; set; }
    public string? Mail { get; set; }

    // Constructeur pour initialiser les propriétés
    public Utilisateur(string name, string firstname, string password, string email) {
        Nom = name;
        Prenom = firstname;
        Mdp = password;
        Mail = email;
    }
}
