namespace StrategyPattern.Strategies
{
	using StrategyPattern.Utilities;
	using UnityEngine;

	[CreateAssetMenu(fileName = "RandomAnnulusSpawnStrategy", menuName = "Strategy Pattern/Random Annulus Spawn Strategy", order = 0)]
	public class RandomAnnulusSpawnStrategy : SpawnStrategy
	{
		public float minDistance;
		public float maxDistance;

		public override Vector3 SetPosition(Vector3 origin) =>
			origin.RandomPointInAnnulus(minDistance, maxDistance);
	}
}
