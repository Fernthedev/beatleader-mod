﻿using System;
using BeatLeader.Models;
using HMUI;
using JetBrains.Annotations;

namespace BeatLeader.Manager {
    [UsedImplicitly]
    internal static class LeaderboardEvents {
        //-- INPUT ------------------

        #region ShowStatusMessage

        public static event Action<string, StatusMessageType, float> StatusMessageEvent;

        public static void ShowStatusMessage(string message, StatusMessageType type = StatusMessageType.Neutral, float duration = 1f) {
            StatusMessageEvent?.Invoke(message, type, duration);
        }

        public enum StatusMessageType {
            Neutral,
            Bad,
            Good
        }

        # endregion

        //-- OUTPUT -----------------

        #region UpButtonWasPressed

        public static event Action UpButtonWasPressedAction;

        public static void NotifyUpButtonWasPressed() {
            UpButtonWasPressedAction?.Invoke();
        }

        #endregion

        #region AroundButtonWasPressed

        public static event Action AroundButtonWasPressedAction;

        public static void NotifyAroundButtonWasPressed() {
            AroundButtonWasPressedAction?.Invoke();
        }

        #endregion

        #region DownButtonWasPressed

        public static event Action DownButtonWasPressedAction;

        public static void NotifyDownButtonWasPressed() {
            DownButtonWasPressedAction?.Invoke();
        }

        #endregion

        #region ReplayButtonWasPressed

        public static event Action<Score> ReplayButtonWasPressedAction;

        public static void NotifyReplayButtonWasPressed(Score score) {
            ReplayButtonWasPressedAction?.Invoke(score);
        }

        #endregion

        #region OnScoreStatsRequested

        public static event Action<int> ScoreStatsRequestedEvent;

        public static void RequestScoreStats(int scoreId) {
            ScoreStatsRequestedEvent?.Invoke(scoreId);
        }

        #endregion
        
        #region SubmitVote

        public static event Action<Vote> SubmitVoteEvent;

        public static void SubmitVote(Vote vote) {
            SubmitVoteEvent?.Invoke(vote);
        }

        #endregion
        
        #region RankedPlaylistUpdateButtonWasPressedAction

        public static event Action RankedPlaylistUpdateButtonWasPressedAction;

        public static void NotifyRankedPlaylistUpdateButtonWasPressed() {
            RankedPlaylistUpdateButtonWasPressedAction?.Invoke();
        }

        #endregion
        
        #region OculusMigrationButtonWasPressedAction

        public static event Action OculusMigrationButtonWasPressedAction;

        public static void NotifyOculusMigrationButtonWasPressed() {
            OculusMigrationButtonWasPressedAction?.Invoke();
        }

        #endregion

        //-- INTERNAL -----------------

        #region ScoreInfoButtonWasPressed

        public static event Action<Score> ScoreInfoButtonWasPressed;

        public static void NotifyScoreInfoButtonWasPressed(Score score) {
            ScoreInfoButtonWasPressed?.Invoke(score);
        }

        #endregion

        #region AvatarWasPressed

        public static event Action AvatarWasPressedEvent;

        public static void NotifyAvatarWasPressed() {
            AvatarWasPressedEvent?.Invoke();
        }

        #endregion

        #region LogoWasPressed

        public static event Action LogoWasPressedEvent;

        public static void NotifyLogoWasPressed() {
            LogoWasPressedEvent?.Invoke();
        }

        #endregion

        #region VotingWasPressed

        public static event Action VotingWasPressedEvent;

        public static void NotifyVotingWasPressed() {
            VotingWasPressedEvent?.Invoke();
        }

        #endregion

        #region HideAllModals

        public static event Action<ModalView> HideAllOtherModalsEvent;

        public static void FireHideAllOtherModalsEvent([CanBeNull] ModalView except) {
            HideAllOtherModalsEvent?.Invoke(except);
        }

        #endregion
    }
}