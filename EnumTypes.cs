namespace URA_Pokemon
{
    public enum Type
    {
        NORMAL,
        FEU,
        EAU,
        PLANTE,
        ELECTRIK,
        GLACE,
        COMBAT,
        POISON,
        SOL,
        VOL,
        PSY,
        INSECTE,
        ROCHE,
        SPECTRE,
        DRAGON,
        TENEBRES,
        ACIER,
        AUCUN
    }

    public enum Statut
    {
        OK,
        SOM,
        PAR,
        POI,
        BRU,
        GEL
    }

    public enum Esp�ce
    {
        Amorphe, // Anciennement Ind�termin�
        Aquatique1, // Anciennement Eau1
        Aquatique2,
        Aquatique3,
        Aucun, // Anciennement Pas de groupe; sert aussi pour faire un pok�mon d'une seule esp�ce comme Dragon/Aucun
        Champ�tre, // Anciennement Pr�
        Dragon,
        F�erique,
        Herbeux, // Anciennement Plante
        Humain,
        Insecte,
        Min�ral,
        Monstre,
        St�rile, // Anciennement Ne peut se reproduire
        Volant
    }

    public enum Apprentissage
    {
        Level,
        CT,
        CTLevel,
        CS,
        CSLevel,
        Oeuf,
        Aucun
    }

    public enum FileType
    {
        Description,
        Fiche
    }

    public enum CapaciteType
    {
        Description,
        InfosPokemon
    }

    public enum EffortPointType
    {
        Atq,
        Def,
        AS,
        DS,
        Vit,
        PV
    }

    public enum Sexe
    {
        M�le,
        Femelle,
        Assexu�
    }

    public enum Nature
    {
        Assur�,
        Bizarre,
        Brave,
        Calme,
        Discret,
        Docile,
        Doux,
        Foufou,
        Gentil,
        Hardi,
        Jovial,
        Lach�,
        Malin,
        Malpoli,
        Mauvais,
        Modeste,
        Na�f,
        Press�,
        Prudent,
        Pudique,
        Relax,
        Rigide,
        S�rieux,
        Solo,
        Timide
    }

    public enum EvoType
    {
        niveau,
        pierre_feu,
        pierre_eau,
        pierre_foudre,
        pierre_plante,
        pierre_soleil,
        pierre_lune,
        bonheur,
        malheur,
        echange,
        echange_avec_objet,
        beaute,
        special
    }

    public enum NatureDegat
    {
        Physique,
        Special,
        Aucun,
        NULL
    }
}