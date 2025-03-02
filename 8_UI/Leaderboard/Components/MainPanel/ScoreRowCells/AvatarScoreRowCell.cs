﻿using BeatLeader.Models;
using BeatSaberMarkupLanguage.Attributes;
using JetBrains.Annotations;

namespace BeatLeader.Components {
    internal class AvatarScoreRowCell : AbstractScoreRowCell {
        #region Components

        private const float Size = 4.0f;

        [UIValue("player-avatar"), UsedImplicitly]
        private PlayerAvatar _playerAvatar;

        private void Awake() {
            _playerAvatar = Instantiate<PlayerAvatar>(transform);
        }

        #endregion

        #region Implementation

        public void SetValues(string url, PlayerRole[] playerRoles) {
            _playerAvatar.SetAvatar(url, playerRoles);
            isEmpty = false;
        }

        public override void SetAlpha(float value) {
            _playerAvatar.SetAlpha(value);
        }

        protected override float CalculatePreferredWidth() {
            return Size;
        }

        #endregion
    }
}