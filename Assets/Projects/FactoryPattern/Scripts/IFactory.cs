namespace FactoryPattern
{
    using FactoryPattern.AIBots;
    using UnityEngine;
    
    public interface IFactory
    {
        Enemy Create(GameObject prefab);
    }
}
