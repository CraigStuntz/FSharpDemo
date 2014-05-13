module UnitsOfMeasure
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

    let momentum (mass: float<kg>) (velocity : float<m/s^2>) = mass * velocity