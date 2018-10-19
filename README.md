## Heritage ##
### TP: Mammifère ###

Le but du Tp est de prendre connaissance de la programmation: Héritage de classes.
En effet, une classe peut hériter d'une autre classe, cela consiste à posséder les mêmes méthodes et attributs que celle-ci.

Les outils mis en oeuvre:
* Git
* Visual Studio
* C#
* Heritage
* Objets

Ici, nous sommes en présence des diagrammes de classe suivant:
![Mammiefere.png](http://image.noelshack.com/fichiers/2018/42/5/1539941887-mammifere.png)

Le travail est le suivant:
Ecrivrez les classes correspondant aux diagrammes de classes en tenant compte des deux hypothèses.

Dans un premier temps il fut nécessaire de créer la classe Mammifère dont les autres classes vont hériter.
Intéressons-nous au consctucteur de Mammifère:
```cs
public Mammifere(string nom, string lieuHabitation, string nomCrie, bool jeSuisDomestique)
{
  this.nom = nom;
  this.lieuHabitation = lieuHabitation;
  this.nomCrie = nomCrie;
  this.jeSuisDomestique = jeSuisDomestique;
}
```
En effet celui-ci va nous permettre de compléter le constructeur des classes Félin et Cétacé.
Afin de déclarer un héritage il est nécessaire de déclarer la ligne suivante:
```cs
class Cetace : Mammifere
```

Le consctructeur est le suivant:
```cs
public Cetace(string nom, string lieuHabitation, string nomCrie, bool jeSuisDomestique, int dureeApnee, int profondeurPlonge)
  : base(nom, lieuHabitation, nomCrie, jeSuisDomestique)
{
  this.dureeApnee = dureeApnee;
  this.profondeurPlonge = profondeurPlonge;
}
```

