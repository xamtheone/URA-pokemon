--- URA Pokemon 1.0 ---
Par XamTheOne (xamtheone@caramail.com)

Index
-1 Petit mot
-2 Config requise
-3 Description
-4 Annexes



1) Petit mot

Si vous tombez sur ce soft c'est que vous avez pas grand chose � faire de vos journ�es!! ^^  En effet je le partage que sur emule alors... ou un pote � moi vous l'a fil� ?! Ou vous connais-je ???!!!

L'est compl�tement gratis de chez gratis!  Pouvez en faire c'que tu veux! :)))))))))))) Mais quand m�me, dites pas que c'est vous qui l'avez fait, hein, mais moi! ;p


2) Config requise
Framework .NET 2.0
... et pis un �cran et une souris :) non sans dec, je le fais tourner sur un Pentium II 400Mhz! M�me si �a prend un peu plus de temps � charger...
Faites gaffe quand m�me, l'outil Accouplement est capable de prendre pas mal de m�moire.

3) Description
Bah c'est un petit programme en C# que je me suis amus� � faire parce que j'en avais marre de calculer tout mes trucs de pok�mon sur papier.
On a donc 10 outils divis� en deux cat�gories:

--- Cat�gotie "Affichage/Infos"

3.1 - Pok�Description ---------------------
	Visualiser les infos sur un pok�mon, comme les attaques qu'il peut apprendre ou bien ses stats de bases.
	Cliquez sur le nom ou sur le num�ro pour changer de pok�mon.
	
3.2 - Pok�Fiche ---------------------------
	Vous pouvez enregistrer les infos sur un de vos pok�mon tel son nom, ses attaques pis ses DV et points d'effort(voir explications en annexe) pour ceux comme moi pour qui c'est indispensable ;).
	Faites juste pas n'importe quoi en marquant le nom de fichier quand vous enregistrer...
	
3.3 - Capacit�s ---------------------------
	Tout simplement des infos sur chaque capacit� du jeu.
	
3.4 - Capacit�s Sp� -----------------------
	Idem pour les capacit�s sp�.
	
3.5 - Filtrer par... ----------------------
	Permet d'afficher une liste filtr� par les crit�res s�lectionn�s (cochez la case correspondante et entrez une valeur) dans le menu de gauche (j'esp�re que vous �tes pas en 800x600).
	Vous pouvez trier les colonnes en cliquant sur l'en-t�te et les afficher/masquer avec un click droit.
	Attention un double click fait apparaitre la fiche du pok�mon s�lectionn�, m�me quand on double click sur l'en-t�te...
	Les colonnes bleu clair repr�sentent les stats de base et les colonnes orange les points d'efforts (voir explications en annexe).
	Laissez la case vide ou d�cocher l'option si vous ne voulez plus qu'une condition soit prise en compte.
	Avant de filtrer par moyenne, choisissez les stats sur lequelles la moyenne est calcul�.
	Cliquez juste sur Filtrer pour afficher tout les pok�mons.
	
	
--- Cat�gorie "Calculs"

3.6 - Types -------------------------------
	Permet de connaitre les faiblesses et r�sistance de tout les types et combinaison de type possibles!
	Petite explication sur la m�thode de calcul:
		La combinaison de types est consid�r� efficace contre un autre type si au moins un des deux type est au minimum "efficace" (d�g�ts x2)
		La combinaison de types est consid�r� peu efficace contre un autre type si les deux types sont incapables de faire des d�g�ts au minimum neutre (d�g�ts x1)
		Ca ne sert � rien de cumuler deux fois le m�me type
		Si vous voyez une diff�rence en inversant les deux types de places, c'est seulement l'ordre d'affichage qui change ;)
		
3.7 - D�g�ts ------------------------------
	Calcule les d�g�ts inflig�s par un pok�mon sur un autre.
	Niveau: niveau du pok�mon qui lance l'attaque.
	Attaque: la valeur de la statistique d'attaque ou d'attaque sp�ciale (en fonction du type de l'attaque lanc�) du pok�mon qui lance l'attaque.
	Efficacit�: efficacit� de l'attaque utilis� sur le pok�mon attaqu� (utiliser "Capacit�s" pour connaitre le type de l'attaque et "Types" pour connaitre l'efficacit�).
	D�fense: d�fense ou d�fense sp�ciale (en fonction du type de l'attaque lanc�) du pok�mon attaqu� (la premi�re des deux inconnues dans un vrai combat).
	Puissance: puissance de l'attaque utilis�(utiliser "Capacit�s" pour le savoir).
	M�me type: Cochez cette case si le type de l'attaque est le m�me que l'un des deux types du pok�mon qui l'utilise(si si, �a fait une diff�rence, voir en annexes).
	Coup critique: me semble assez clair :)
	Random: Cette valeur est choisi al�atoirement quand vous lancez une attaque et varie entre 217 et 255.  Note: si vous utilisez cet outil pour connaitre les stats requise par votre pok�mon, je vous conseille fortement de mettre Random � 255 pour tester votre d�fense et � 217 pour tester votre attaque!
	
3.8 - Stats -------------------------------
	Permet de calculer pr�cis�ment les statistiques d'un pok�mon � un niveau donn�.
	Vous avez plusieurs m�thodes possibles d'indiquer les points d'efforts(voir explications en annexes):
		Maxi: Met toutes les stats au maximum.
		global: indique la quantit� de points d'efforts pour toutes les stats.
		Par stat: sp�cifie individuellement les points d'efforts de chaque stat.
		
3.9 - DV ----------------------------------
	Vous allez enfin pouvoir connaitre les DV (voir explications en annexes) de vos pok�mon fraichements captur�s!
	!!! ATTENTION, pour proc�der au calcul d'un DV d'une statistique, les points d'efforts de la stat doivent �tre � 0 !!!
	Mais comment �a marche? Je vais prendre un exemple:
		Je viend de capturer un GALEKID niveau 8 de nature Brave.
		Je choisi GALEKID dans la liste d�roulante, j'entre son niveau dans Niveau de d�part et je renseigne les stats qui m'int�resse par les valeurs actuels de mon pok�mon, je met sa nature � Brave(A+, V-), puis je click sur le bouton Suivant.
		L� j'obtiens une plage de valeur m'indiquant par exemple que l'attaque de mon GALEKID (je vais dire n'importe quoi) est entre 10 et 18.  Ce qui veut dire que son DV d'attaque est compris entre 10 et 18 (les deux inclus).
		A cot� de niveau en attente je vois marqu� 9, ce qui veut dire que le prochain niveau significatif auquel je dois monter mon pok�mon est 9.  Il se peut que le niveau monte de plusieurs niveaux d'un coup, c'est tout � fait normal: cela signifie que de calculer tous les niveaux entre l'ancienne et la nouvelle valeur n'apporte aucune information.
		Maintenant je renseigne les m�me stats que j'ai entr� au d�part mais avec leur valeurs au niveau 9.  Et je m'apper�ois par exemple (et je dis encore n'importe quoi) que l'attaque de mon GALEKID est entre 12 et 17.  Gr�ce au nouveau calcul, nous avons pu resserer la plage de valeurs possible pour le DV d'attaque de mon GALEKID.  En poursuivant cette d�marche, j'obtiendrai la valeur exacte du DV d'attaque, genre 15 par exemple.
		
	Avec le bouton Pr�c�dent, si vous vous appercevez que vous vous �tes tromp� en entrant une valeur, vous pouvez toujours revenir en arri�re, m�me plusieurs fois, mais il faudra � nouveau renseigner toutes les stats que vous calculer.
	Pour calculer un nouveau pok�mon n'oubliez pas de cliquer sur Nouveau.  La nature ne changera pas, c'est normal. Zavez qu'a le faire vous m�me!
	
3.10 - Accouplement ----------------------- :))))))))))))))))))))
	Calcule les accouplements necessaires pour faire apprendre une capacit� � un pok�mon.
	Choisissez un pok�mon, une ou plusieurs des capacit�s propos�es et cliquez sur calculer!
	Attention certain calculs peuvent mettre beaucoup de temps � aboutir !! Particuli�rement ceux incluant des attaques que beaucoup de pok�mons peuvent apprendre, tel TOXIK ou ABRI.
	Pour all�ger le calcul, vous pouvez choisir de restreintre le niveau de recherche en changeant la valeur de "Limiter la recherche �".  Mettez cette valeur � 0 pour ne pas limiter.  Niveau 1 signifie que l'on ne cherchera que les possibilit�s n�cessitant un seul accouplement, niveau 2 pour un et deux accouplements, etc..
	Vous pouvez d�finir la fa�on dont l'arboresence est affich�.  Si vous laissez coch� "D�ployer tout", toute l'arborescence sera affich�.  A l'inverse, vous pouvez d�finir le nombre de niveau � d�ployer en d�cochant cette case. 0 �quivaut � aucun noeud d�ploy�, soit le pok�mon choisi visible uniquement.  Cliquez sur d�ployer pour appliquer les changements.  Ces options sont prisent en compte lorsque le calcul s'ach�ve.
	
4) - Annexes

4.1 - Jargon ------------------------------

PV: Points de Vie
A: Attaque
D: D�fense
AS: Attaque Sp�ciale
DS: D�fense Sp�ciale
V: Vitesse

DV: Diversification Value, aussi connu sous le nom de IV, Individual Value.
PE: Point d'Effort


4.2 - Les DV ------------------------------

Les DV sont des �l�ments indispendables � connaitre si vous voulez exploiter � font le potentiel d'une esp�ce pok�mon.  Tout pok�mon en poss�de, et c'est ce qui fait leur diff�rence (entre autre).

A chaque statistique est attribu� un DV, c'est � dire une valeur entre 0 et 31, qui influence le calcul de la statistique.  Plus le DV est �lev�, plus la statistique sera �lev�.  Ces valeurs sont attribu�es � la premi�re rencontre d'un pok�mon, au moment o� il apparait, quand on vous le donne, ou que vous le prenez(faites le test devant un pok�mon l�gendaire, sauvegardez votre partie, capturez le, calculez ses DV, puis reprenez votre sauvegarde et faire la m�me chose; les DV aurrons chang�s).

Il est donc nettement plus int�ressant d'avoir un pok�mon avec tout les DV � 31 qu'� 0! Agissez en cons�quence :)

Une chose tr�s int�ressante � savoir est que lors d'un accouplement, les parents transmettent leurs propre DV de cette mani�re:

Deux DV sont choisi au hazard chez l'un des parents, et un seul est choisi, toujours au hazard, chez l'autre parent.  Les trois DV choisi seront transmis dans les m�mes stats qu'ils concernent � l'oeuf que la m�re ponderra.
Si les DV choisi chez chaque parent se chevauchent, L'un des deux seulement sera choisi, et deux DV seulements seront transmis.

Il n'y a aucun moyen de modifier les DV d'un pok�mon sans tricher et modifier la sauvegarde.

Les formules de calculs de statistiques sont d�critent plus loin et montre de quelle mani�re les DV influencent les stats.


4.3 - Les points d'efforts ----------------

Les points d'efforts sont obtenu quand vous battez un pok�mon, et la quantit� re�u d�pent de l'esp�ce du pok�mon que vous avez battu (exemple: n'importe quel AIRMURE battu, qu'importe le niveau, raporte 2 points d'efforts en d�fense).  Les PE influencent les statistiques, et plus vous avez de PE plus vos stats seront �lev�.
Il y a des PE pour chaque statistique, et toutes ne pouront pas obtenir tout leurs PE.
Le maximum de PE toutes stats confondu qu'un pok�mon peut accumuler est de 510.  Le maximum de PE pour une seul statistique est de 255.

Vous pouvez obtenir des PE autrement qu'au combat, gr�ce � des objets dont voici la liste:

(Chaque objet donne 10 PE)
PV Plus -> PV
Proteine -> Attaque
Fer -> D�fense
Calcium -> Attaque sp�ciale
Zinc -> D�fense sp�ciale
Carbone -> Vitesse

Vous ne pourez plus utiliser un de ces objets si les PE de la stat concern� sont �gaux ou supp�rieur � 100.  Donc avant de faire le moindre combat avec un pok�mon, bourrez le dans les stats requises pour gagner du temps sur l'entrainement.

Un bon moyen de gagner des PE est d'�quiper le pok�mon souhait� du BRAC. MACHO, qui doublera vos gains en PE.

Si votre pok�mon attrape le Pok�Virus, il gagnera deux fois plus de PE en combat.

Les formules de calculs de statistiques sont d�critent plus loin et montre de quelle mani�re les PE influencent les stats.


4.4 - Les stats de base -------------------

Ce que j'appelle les stats de base sont les valeurs fixes qui sont diff�rentes chez chaque esp�ce de pok�mon et servent � calculer les statistiques des pok�mons.  Par exemple vous avez s�rement remarqu� qu'un ONIX poss�de une grande d�fense mais une pi�tre d�fense sp�ciale. Et bien la stat de base de sa d�fense est de 160 et sa d�fense sp�ciale est de 30.  Ceci est vrai pour tous les ONIX.

---------
On notera en regardant les formules de calculs que la stat de base est invariablement multipli� par 2.  Donc on pourrai tr�s bien doubler la valeur des stats de base et oter le x2 des formules.  La raison pour laquelle je l'ai laiss� de cette fa�on est que j'ai l'habitude, et d'autre personnes aussi, de regarder les stats de base en r�f�rence au niveau 50.

Ce que cela signifie est que par exemple pour une valeur de base de 100, une stat d'attaque au niveau 50, DV 0, PV 0 et nature neutre vaudra 100 + 5 = 105.

De m�me, si on rajoute un DV � 31 on optient 100 + 5 + 15 = 120.

Et PE � 255 donne 100 + 5 + 15 + 31 = 151.

C'est simple.  Et comme j'ai commenc� � me concentrer sur des pok�mon de niveau 50 pour gagner des coupes de Pok�mon Stadium (du temps de Pok�mon Or & Argent), je n'ai pas chang� depuis.
--------

4.5 - Les formules ------------------------

Avec les formules de calculs des statistiques, de d�g�ts, et de modifications de statistiques, vous allez d�couvrir comment fonctionne la m�chanique de pok�mon.

Formule de calcul des PV:

-----------------------------------------------------------
Tr((2 * PV + DV + Tr(PE / 4)) * Niveau / 100 + 10 + Niveau)
-----------------------------------------------------------

Tr: tronque le r�sultat. Par exemple Tr(3.2) = 3 et Tr(3.9) = 3
PV: PV de base de l'esp�ce du pok�mon
DV: DV de PV du pok�mon (entre 0 et 31)
PE: Points d'efforts accumul�s pour les PV
Niveau: Le niveau actuel du pok�mon

Avec un ONIX niveau 35, DV de PV � 20 et PE de PV � 100, on obtient donc: 85 PV.

----------
Note - Le cas MUNJA:

MUNJA est le seul pok�mon dont les PV ne d�pendent pas de cette formule.  En effet, tout MUNJA aura ses PV � 1, sans alt�ration possible de ce nombre.
----------

Formule de calcul des stats (autre que PV)

-------------------------------------------------------------
Tr(Tr((2 * S + DV + Tr(PE / 4)) * Niveau / 100 + 5) * Nature)
-------------------------------------------------------------

Tr: tronque le r�sultat. Par exemple Tr(3.2) = 3 et Tr(2.9) = 2
S: stat de base de l'esp�ce du pok�mon
DV: DV de la stat du pok�mon (entre 0 et 31)
PE: Points d'efforts accumul�s pour la stat
Niveau: Le niveau actuel du pok�mon
Nature: Si la nature du pok�mon influe positivement sur la stat calcul�, Nature vaut 1.1 .  Au contraire, si la nature est d�favorable, Nature vaut 0.9 . Sinon Nature vaut 1.

Avec un ONIX "S�rieux" niveau 35, DV d'attaque � 20 et PE d'attaque � 100, on obtient donc: 52.

Maintenant que nous savons cela, regardons l'importance de chaque �l�ment de la formule de calcul de stats.

Prenons ce bon vieux ONIX qui nous a bien servi jusqu'� maintenant.  La stat de base de sa vitesse vaut 70.
Avec une nature neutre, DV et PV � 0, au niveau 50 sa vitesse vaut:

Tr(Tr((2 * 70 + 0 + Tr(0 / 4)) * 50 / 100 + 5) * 1) =
Tr(140 * 0.5 + 5) = 75

Maintenant changeons le DV de vitesse d'ONIX et mettons le � 31:

Tr(Tr((2 * 70 + 31 + Tr(0 / 4)) * 50 / 100 + 5) * 1) =
Tr(171 * 0.5 + 5) = 90

Remettons le DV � 0 et changeons les PE � 255:

Tr(Tr((2 * 70 + 0 + Tr(255 / 4)) * 50 / 100 + 5) * 1) =
Tr((140 + 63) * 0.5 + 5) = 106

On remet les PE � 0 et on change la nature en nature favorable:

Tr(Tr((2 * 70 + 0 + Tr(0 / 4)) * 50 / 100 + 5) * 1.1) =
Tr(Tr(140 * 0.5 + 5) * 1.1) = 82

Et maintenant, on met tout � fond! :

Tr(Tr((2 * 70 + 31 + Tr(255 / 4)) * 50 / 100 + 5) * 1.1) =
Tr(Tr((140 + 31 + 63) * 0.5 + 5) * 1.1) = 
Tr(122 * 1.1) = 134

Pas mal comme optimisation!


Formule de calcul des d�g�ts:

-------------------------------------------------------------------------
Tr(((((2 * Niveau * C / 5 + 2) * A * F / D) / 50 + 2) * S * E * R / 255))
-------------------------------------------------------------------------

Tr: tronque le r�sultat. Par exemple Tr(3.2) = 3 et Tr(2.9) = 2
Niveau: Niveau du pok�mon qui lance l'attaque
C: Coup critique
A: Attaque ou attaque sp�ciale du pok�mon qui lance l'attaque
F: Force de l'attaque lanc�
D: D�fense ou d�fense sp�ciale du pok�mon attaqu�
S: STAB (Same Type Attack Bonus) Vaux 1 si le type de l'attaque est diff�rent du type ou des deux type de l'attaquant, sinon 1.5
E: Efficacit� (0, 0.25, 0.5, 1, 2, 4)
R: Valeur al�atoire entre 217 et 255

Ainsi, un pok�mon niveau 50 avec une attaque de 130 de type SOL qui lance s�isme (type SOL, force 100) sur un pok�mon de type POISON avec une d�fense de 145 et une valeur R � 255 ferait perdre:

Tr(((((2 * 50 * 1 / 5 + 2) * 130 * 100 / 145) / 50 + 2) * 1.5 * 2 * 255 / 255)) =
Tr((((27 * 13000 / 145) / 50 + 2) * 3)) = 124 PV

Echelle de niveaux d'alt�ration des stats:

Niveaux
-6    -5    -4    -3    -2    -1    0    1    2    3    4    5    6
-------------------------------------------------------------------
1/4   2/7   1/3   2/5   1/2   2/3   1   3/2   2   5/2   3   7/2   4
Facteur multiplicateur


Une capacit� comme DANSE-LAMES augmente de deux niveau l'attaque, ce qui signifie selon le tableau que l'attaque est multipli� par 2




