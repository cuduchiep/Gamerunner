using System;

using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Modifiers
{
    public class ModifierCrowd : ModifierBase
    {
        [SerializeField] private ModifierView modifierView;
        [SerializeField] private int crowdModifyAmount = 2;
        private bool _isPositive;

        private void Start()
        {
            _isPositive = crowdModifyAmount > 0;
            modifierView.SetVisuals(_isPositive, crowdModifyAmount);
        }


        public override void Modify(PlayerController playerController)
        {
            var playerCrowd = playerController.GetComponent<PlayerCrowd>();
            playerCrowd.AddCountToCrowd(crowdModifyAmount);
            for (int i = 1; i < Mathf.Abs(crowdModifyAmount); i++)
            {
                if(_isPositive) playerCrowd.AddShooter();
                else playerCrowd.RemoveShooter();
            }
        }
    }
}