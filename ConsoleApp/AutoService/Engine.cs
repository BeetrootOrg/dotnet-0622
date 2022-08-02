class Engine
{
    /// <summary>
    /// Ємність.
    /// </summary>
    /// <value></value>
    public float Capacity { get; init; }
    /// <summary>
    /// Конфігурація. Наприклад: V-образний
    /// </summary>
    /// <value></value>
    public string Configuration { get; init; }
    public float CylinderDiameter { get; init; }
    /// <summary>
    /// Тип впуску палива.
    /// </summary>
    /// <value></value>
    public string IntakeType { get; init; }
    /// <summary>
    /// Максимальний крутний момент.
    /// </summary>
    /// <value></value>
    public int MaxTorque { get; init; }
    public int NumberOfCylinders { get; init; }
    /// <summary>
    /// Кількість клапанів.
    /// </summary>
    /// <value></value>
    public int NumberOfValves { get; init; }
    /// <summary>
    /// Хід поршня.
    /// </summary>
    /// <value></value>
    public float PistonStroke { get; init; }
    public int Power { get; init; }
    public string Type { get; init; }
}