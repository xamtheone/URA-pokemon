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

    public enum Espèce
    {
        Amorphe, // Anciennement Indéterminé
        Aquatique1, // Anciennement Eau1
        Aquatique2,
        Aquatique3,
        Aucun, // Anciennement Pas de groupe; sert aussi pour faire un pokémon d'une seule espèce comme Dragon/Aucun
        Champêtre, // Anciennement Pré
        Dragon,
        Féerique,
        Herbeux, // Anciennement Plante
        Humain,
        Insecte,
        Minéral,
        Monstre,
        Stérile, // Anciennement Ne peut se reproduire
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
        Mâle,
        Femelle,
        Assexué
    }

    public enum Nature
    {
        Assuré,
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
        Laché,
        Malin,
        Malpoli,
        Mauvais,
        Modeste,
        Naïf,
        Pressé,
        Prudent,
        Pudique,
        Relax,
        Rigide,
        Sérieux,
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