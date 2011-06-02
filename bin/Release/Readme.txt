--- URA Pokemon 1.0 ---
Par XamTheOne (xamtheone@caramail.com)

Index
-1 Petit mot
-2 Config requise
-3 Description
-4 Annexes



1) Petit mot

Si vous tombez sur ce soft c'est que vous avez pas grand chose à faire de vos journées!! ^^  En effet je le partage que sur emule alors... ou un pote à moi vous l'a filé ?! Ou vous connais-je ???!!!

L'est complètement gratis de chez gratis!  Pouvez en faire c'que tu veux! :)))))))))))) Mais quand même, dites pas que c'est vous qui l'avez fait, hein, mais moi! ;p


2) Config requise
Framework .NET 2.0
... et pis un écran et une souris :) non sans dec, je le fais tourner sur un Pentium II 400Mhz! Même si ça prend un peu plus de temps à charger...
Faites gaffe quand même, l'outil Accouplement est capable de prendre pas mal de mémoire.

3) Description
Bah c'est un petit programme en C# que je me suis amusé à faire parce que j'en avais marre de calculer tout mes trucs de pokémon sur papier.
On a donc 10 outils divisé en deux catégories:

--- Catégotie "Affichage/Infos"

3.1 - PokéDescription ---------------------
	Visualiser les infos sur un pokémon, comme les attaques qu'il peut apprendre ou bien ses stats de bases.
	Cliquez sur le nom ou sur le numéro pour changer de pokémon.
	
3.2 - PokéFiche ---------------------------
	Vous pouvez enregistrer les infos sur un de vos pokémon tel son nom, ses attaques pis ses DV et points d'effort(voir explications en annexe) pour ceux comme moi pour qui c'est indispensable ;).
	Faites juste pas n'importe quoi en marquant le nom de fichier quand vous enregistrer...
	
3.3 - Capacités ---------------------------
	Tout simplement des infos sur chaque capacité du jeu.
	
3.4 - Capacités Spé -----------------------
	Idem pour les capacités spé.
	
3.5 - Filtrer par... ----------------------
	Permet d'afficher une liste filtré par les critères sélectionnés (cochez la case correspondante et entrez une valeur) dans le menu de gauche (j'espère que vous êtes pas en 800x600).
	Vous pouvez trier les colonnes en cliquant sur l'en-tête et les afficher/masquer avec un click droit.
	Attention un double click fait apparaitre la fiche du pokémon sélectionné, même quand on double click sur l'en-tête...
	Les colonnes bleu clair représentent les stats de base et les colonnes orange les points d'efforts (voir explications en annexe).
	Laissez la case vide ou décocher l'option si vous ne voulez plus qu'une condition soit prise en compte.
	Avant de filtrer par moyenne, choisissez les stats sur lequelles la moyenne est calculé.
	Cliquez juste sur Filtrer pour afficher tout les pokémons.
	
	
--- Catégorie "Calculs"

3.6 - Types -------------------------------
	Permet de connaitre les faiblesses et résistance de tout les types et combinaison de type possibles!
	Petite explication sur la méthode de calcul:
		La combinaison de types est considéré efficace contre un autre type si au moins un des deux type est au minimum "efficace" (dégâts x2)
		La combinaison de types est considéré peu efficace contre un autre type si les deux types sont incapables de faire des dégâts au minimum neutre (dégâts x1)
		Ca ne sert à rien de cumuler deux fois le même type
		Si vous voyez une différence en inversant les deux types de places, c'est seulement l'ordre d'affichage qui change ;)
		
3.7 - Dégâts ------------------------------
	Calcule les dégâts infligés par un pokémon sur un autre.
	Niveau: niveau du pokémon qui lance l'attaque.
	Attaque: la valeur de la statistique d'attaque ou d'attaque spéciale (en fonction du type de l'attaque lancé) du pokémon qui lance l'attaque.
	Efficacité: efficacité de l'attaque utilisé sur le pokémon attaqué (utiliser "Capacités" pour connaitre le type de l'attaque et "Types" pour connaitre l'efficacité).
	Défense: défense ou défense spéciale (en fonction du type de l'attaque lancé) du pokémon attaqué (la première des deux inconnues dans un vrai combat).
	Puissance: puissance de l'attaque utilisé(utiliser "Capacités" pour le savoir).
	Même type: Cochez cette case si le type de l'attaque est le même que l'un des deux types du pokémon qui l'utilise(si si, ça fait une différence, voir en annexes).
	Coup critique: me semble assez clair :)
	Random: Cette valeur est choisi aléatoirement quand vous lancez une attaque et varie entre 217 et 255.  Note: si vous utilisez cet outil pour connaitre les stats requise par votre pokémon, je vous conseille fortement de mettre Random à 255 pour tester votre défense et à 217 pour tester votre attaque!
	
3.8 - Stats -------------------------------
	Permet de calculer précisément les statistiques d'un pokémon à un niveau donné.
	Vous avez plusieurs méthodes possibles d'indiquer les points d'efforts(voir explications en annexes):
		Maxi: Met toutes les stats au maximum.
		global: indique la quantité de points d'efforts pour toutes les stats.
		Par stat: spécifie individuellement les points d'efforts de chaque stat.
		
3.9 - DV ----------------------------------
	Vous allez enfin pouvoir connaitre les DV (voir explications en annexes) de vos pokémon fraichements capturés!
	!!! ATTENTION, pour procéder au calcul d'un DV d'une statistique, les points d'efforts de la stat doivent être à 0 !!!
	Mais comment ça marche? Je vais prendre un exemple:
		Je viend de capturer un GALEKID niveau 8 de nature Brave.
		Je choisi GALEKID dans la liste déroulante, j'entre son niveau dans Niveau de départ et je renseigne les stats qui m'intéresse par les valeurs actuels de mon pokémon, je met sa nature à Brave(A+, V-), puis je click sur le bouton Suivant.
		Là j'obtiens une plage de valeur m'indiquant par exemple que l'attaque de mon GALEKID (je vais dire n'importe quoi) est entre 10 et 18.  Ce qui veut dire que son DV d'attaque est compris entre 10 et 18 (les deux inclus).
		A coté de niveau en attente je vois marqué 9, ce qui veut dire que le prochain niveau significatif auquel je dois monter mon pokémon est 9.  Il se peut que le niveau monte de plusieurs niveaux d'un coup, c'est tout à fait normal: cela signifie que de calculer tous les niveaux entre l'ancienne et la nouvelle valeur n'apporte aucune information.
		Maintenant je renseigne les même stats que j'ai entré au départ mais avec leur valeurs au niveau 9.  Et je m'apperçois par exemple (et je dis encore n'importe quoi) que l'attaque de mon GALEKID est entre 12 et 17.  Grâce au nouveau calcul, nous avons pu resserer la plage de valeurs possible pour le DV d'attaque de mon GALEKID.  En poursuivant cette démarche, j'obtiendrai la valeur exacte du DV d'attaque, genre 15 par exemple.
		
	Avec le bouton Précédent, si vous vous appercevez que vous vous êtes trompé en entrant une valeur, vous pouvez toujours revenir en arrière, même plusieurs fois, mais il faudra à nouveau renseigner toutes les stats que vous calculer.
	Pour calculer un nouveau pokémon n'oubliez pas de cliquer sur Nouveau.  La nature ne changera pas, c'est normal. Zavez qu'a le faire vous même!
	
3.10 - Accouplement ----------------------- :))))))))))))))))))))
	Calcule les accouplements necessaires pour faire apprendre une capacité à un pokémon.
	Choisissez un pokémon, une ou plusieurs des capacités proposées et cliquez sur calculer!
	Attention certain calculs peuvent mettre beaucoup de temps à aboutir !! Particulièrement ceux incluant des attaques que beaucoup de pokémons peuvent apprendre, tel TOXIK ou ABRI.
	Pour alléger le calcul, vous pouvez choisir de restreintre le niveau de recherche en changeant la valeur de "Limiter la recherche à".  Mettez cette valeur à 0 pour ne pas limiter.  Niveau 1 signifie que l'on ne cherchera que les possibilités nécessitant un seul accouplement, niveau 2 pour un et deux accouplements, etc..
	Vous pouvez définir la façon dont l'arboresence est affiché.  Si vous laissez coché "Déployer tout", toute l'arborescence sera affiché.  A l'inverse, vous pouvez définir le nombre de niveau à déployer en décochant cette case. 0 équivaut à aucun noeud déployé, soit le pokémon choisi visible uniquement.  Cliquez sur déployer pour appliquer les changements.  Ces options sont prisent en compte lorsque le calcul s'achève.
	
4) - Annexes

4.1 - Jargon ------------------------------

PV: Points de Vie
A: Attaque
D: Défense
AS: Attaque Spéciale
DS: Défense Spéciale
V: Vitesse

DV: Diversification Value, aussi connu sous le nom de IV, Individual Value.
PE: Point d'Effort


4.2 - Les DV ------------------------------

Les DV sont des éléments indispendables à connaitre si vous voulez exploiter à font le potentiel d'une espèce pokémon.  Tout pokémon en possède, et c'est ce qui fait leur différence (entre autre).

A chaque statistique est attribué un DV, c'est à dire une valeur entre 0 et 31, qui influence le calcul de la statistique.  Plus le DV est élevé, plus la statistique sera élevé.  Ces valeurs sont attribuées à la première rencontre d'un pokémon, au moment où il apparait, quand on vous le donne, ou que vous le prenez(faites le test devant un pokémon légendaire, sauvegardez votre partie, capturez le, calculez ses DV, puis reprenez votre sauvegarde et faire la même chose; les DV aurrons changés).

Il est donc nettement plus intéressant d'avoir un pokémon avec tout les DV à 31 qu'à 0! Agissez en conséquence :)

Une chose très intéressante à savoir est que lors d'un accouplement, les parents transmettent leurs propre DV de cette manière:

Deux DV sont choisi au hazard chez l'un des parents, et un seul est choisi, toujours au hazard, chez l'autre parent.  Les trois DV choisi seront transmis dans les mêmes stats qu'ils concernent à l'oeuf que la mère ponderra.
Si les DV choisi chez chaque parent se chevauchent, L'un des deux seulement sera choisi, et deux DV seulements seront transmis.

Il n'y a aucun moyen de modifier les DV d'un pokémon sans tricher et modifier la sauvegarde.

Les formules de calculs de statistiques sont décritent plus loin et montre de quelle manière les DV influencent les stats.


4.3 - Les points d'efforts ----------------

Les points d'efforts sont obtenu quand vous battez un pokémon, et la quantité reçu dépent de l'espèce du pokémon que vous avez battu (exemple: n'importe quel AIRMURE battu, qu'importe le niveau, raporte 2 points d'efforts en défense).  Les PE influencent les statistiques, et plus vous avez de PE plus vos stats seront élevé.
Il y a des PE pour chaque statistique, et toutes ne pouront pas obtenir tout leurs PE.
Le maximum de PE toutes stats confondu qu'un pokémon peut accumuler est de 510.  Le maximum de PE pour une seul statistique est de 255.

Vous pouvez obtenir des PE autrement qu'au combat, grâce à des objets dont voici la liste:

(Chaque objet donne 10 PE)
PV Plus -> PV
Proteine -> Attaque
Fer -> Défense
Calcium -> Attaque spéciale
Zinc -> Défense spéciale
Carbone -> Vitesse

Vous ne pourez plus utiliser un de ces objets si les PE de la stat concerné sont égaux ou suppérieur à 100.  Donc avant de faire le moindre combat avec un pokémon, bourrez le dans les stats requises pour gagner du temps sur l'entrainement.

Un bon moyen de gagner des PE est d'équiper le pokémon souhaité du BRAC. MACHO, qui doublera vos gains en PE.

Si votre pokémon attrape le PokéVirus, il gagnera deux fois plus de PE en combat.

Les formules de calculs de statistiques sont décritent plus loin et montre de quelle manière les PE influencent les stats.


4.4 - Les stats de base -------------------

Ce que j'appelle les stats de base sont les valeurs fixes qui sont différentes chez chaque espèce de pokémon et servent à calculer les statistiques des pokémons.  Par exemple vous avez sûrement remarqué qu'un ONIX possède une grande défense mais une piètre défense spéciale. Et bien la stat de base de sa défense est de 160 et sa défense spéciale est de 30.  Ceci est vrai pour tous les ONIX.

---------
On notera en regardant les formules de calculs que la stat de base est invariablement multiplié par 2.  Donc on pourrai très bien doubler la valeur des stats de base et oter le x2 des formules.  La raison pour laquelle je l'ai laissé de cette façon est que j'ai l'habitude, et d'autre personnes aussi, de regarder les stats de base en référence au niveau 50.

Ce que cela signifie est que par exemple pour une valeur de base de 100, une stat d'attaque au niveau 50, DV 0, PV 0 et nature neutre vaudra 100 + 5 = 105.

De même, si on rajoute un DV à 31 on optient 100 + 5 + 15 = 120.

Et PE à 255 donne 100 + 5 + 15 + 31 = 151.

C'est simple.  Et comme j'ai commencé à me concentrer sur des pokémon de niveau 50 pour gagner des coupes de Pokémon Stadium (du temps de Pokémon Or & Argent), je n'ai pas changé depuis.
--------

4.5 - Les formules ------------------------

Avec les formules de calculs des statistiques, de dégâts, et de modifications de statistiques, vous allez découvrir comment fonctionne la méchanique de pokémon.

Formule de calcul des PV:

-----------------------------------------------------------
Tr((2 * PV + DV + Tr(PE / 4)) * Niveau / 100 + 10 + Niveau)
-----------------------------------------------------------

Tr: tronque le résultat. Par exemple Tr(3.2) = 3 et Tr(3.9) = 3
PV: PV de base de l'espèce du pokémon
DV: DV de PV du pokémon (entre 0 et 31)
PE: Points d'efforts accumulés pour les PV
Niveau: Le niveau actuel du pokémon

Avec un ONIX niveau 35, DV de PV à 20 et PE de PV à 100, on obtient donc: 85 PV.

----------
Note - Le cas MUNJA:

MUNJA est le seul pokémon dont les PV ne dépendent pas de cette formule.  En effet, tout MUNJA aura ses PV à 1, sans altération possible de ce nombre.
----------

Formule de calcul des stats (autre que PV)

-------------------------------------------------------------
Tr(Tr((2 * S + DV + Tr(PE / 4)) * Niveau / 100 + 5) * Nature)
-------------------------------------------------------------

Tr: tronque le résultat. Par exemple Tr(3.2) = 3 et Tr(2.9) = 2
S: stat de base de l'espèce du pokémon
DV: DV de la stat du pokémon (entre 0 et 31)
PE: Points d'efforts accumulés pour la stat
Niveau: Le niveau actuel du pokémon
Nature: Si la nature du pokémon influe positivement sur la stat calculé, Nature vaut 1.1 .  Au contraire, si la nature est défavorable, Nature vaut 0.9 . Sinon Nature vaut 1.

Avec un ONIX "Sérieux" niveau 35, DV d'attaque à 20 et PE d'attaque à 100, on obtient donc: 52.

Maintenant que nous savons cela, regardons l'importance de chaque élément de la formule de calcul de stats.

Prenons ce bon vieux ONIX qui nous a bien servi jusqu'à maintenant.  La stat de base de sa vitesse vaut 70.
Avec une nature neutre, DV et PV à 0, au niveau 50 sa vitesse vaut:

Tr(Tr((2 * 70 + 0 + Tr(0 / 4)) * 50 / 100 + 5) * 1) =
Tr(140 * 0.5 + 5) = 75

Maintenant changeons le DV de vitesse d'ONIX et mettons le à 31:

Tr(Tr((2 * 70 + 31 + Tr(0 / 4)) * 50 / 100 + 5) * 1) =
Tr(171 * 0.5 + 5) = 90

Remettons le DV à 0 et changeons les PE à 255:

Tr(Tr((2 * 70 + 0 + Tr(255 / 4)) * 50 / 100 + 5) * 1) =
Tr((140 + 63) * 0.5 + 5) = 106

On remet les PE à 0 et on change la nature en nature favorable:

Tr(Tr((2 * 70 + 0 + Tr(0 / 4)) * 50 / 100 + 5) * 1.1) =
Tr(Tr(140 * 0.5 + 5) * 1.1) = 82

Et maintenant, on met tout à fond! :

Tr(Tr((2 * 70 + 31 + Tr(255 / 4)) * 50 / 100 + 5) * 1.1) =
Tr(Tr((140 + 31 + 63) * 0.5 + 5) * 1.1) = 
Tr(122 * 1.1) = 134

Pas mal comme optimisation!


Formule de calcul des dégâts:

-------------------------------------------------------------------------
Tr(((((2 * Niveau * C / 5 + 2) * A * F / D) / 50 + 2) * S * E * R / 255))
-------------------------------------------------------------------------

Tr: tronque le résultat. Par exemple Tr(3.2) = 3 et Tr(2.9) = 2
Niveau: Niveau du pokémon qui lance l'attaque
C: Coup critique
A: Attaque ou attaque spéciale du pokémon qui lance l'attaque
F: Force de l'attaque lancé
D: Défense ou défense spéciale du pokémon attaqué
S: STAB (Same Type Attack Bonus) Vaux 1 si le type de l'attaque est différent du type ou des deux type de l'attaquant, sinon 1.5
E: Efficacité (0, 0.25, 0.5, 1, 2, 4)
R: Valeur aléatoire entre 217 et 255

Ainsi, un pokémon niveau 50 avec une attaque de 130 de type SOL qui lance séisme (type SOL, force 100) sur un pokémon de type POISON avec une défense de 145 et une valeur R à 255 ferait perdre:

Tr(((((2 * 50 * 1 / 5 + 2) * 130 * 100 / 145) / 50 + 2) * 1.5 * 2 * 255 / 255)) =
Tr((((27 * 13000 / 145) / 50 + 2) * 3)) = 124 PV

Echelle de niveaux d'altération des stats:

Niveaux
-6    -5    -4    -3    -2    -1    0    1    2    3    4    5    6
-------------------------------------------------------------------
1/4   2/7   1/3   2/5   1/2   2/3   1   3/2   2   5/2   3   7/2   4
Facteur multiplicateur


Une capacité comme DANSE-LAMES augmente de deux niveau l'attaque, ce qui signifie selon le tableau que l'attaque est multiplié par 2




