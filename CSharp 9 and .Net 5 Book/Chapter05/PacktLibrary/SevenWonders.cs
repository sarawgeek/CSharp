namespace Packt.Shared
{
    [System.Flags]
    public enum SevenAncientWonders : byte
    {
        None = 0b_000_000_000, // i.e. 0
        GreatPyramidOfGiza = 0b_000_000_001, // i.e. 1
        HangingGardensOfBabylon = 0b_000_000_010, // i.e. 2,
        StatueOfZeusAtOlympia = 0b_000_000_100, // i.e. 4,
        TempleOfArtemisAtEphesus = 0b_000_001_000, // i.e. 8,
        MausoleumAtHalicarnassus = 0b_000_010_000, // i.e. 16,
        ColossusOfRhodes = 0b_000_100_000, // i.e. 32,
        LighthouseOfAlexandria = 0b_001_000_000 // i.e. 64
    }
}