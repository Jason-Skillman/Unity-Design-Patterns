namespace StrategyPattern.Strategies
{
	using UnityEngine;

	[CreateAssetMenu(fileName = "SpawnStrategy", menuName = "Strategy Pattern/Spawn Strategy", order = 0)]
	public class SpawnStrategy : ScriptableObject
	{
		public virtual Vector3 SetPosition(Vector3 origin) => origin;
	}
}
