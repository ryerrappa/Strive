﻿// ReSharper disable InconsistentNaming

namespace PaderConference.Core.Services
{
    public enum ServiceErrorCode
    {
        // 0-1000 reserved for UI

        // 1001- 2000 reserved for SFU

        // Common
        ParticipantNotFound,
        PermissionDenied,


        // Conference
        Conference_NotFound,
        Conference_UnexpectedError,
        Conference_NotOpen,
        Conference_ParticipantNotRegistered,
        Conference_InternalServiceError,
        Conference_ParticipantConnectionNotFound,
        Conference_InternalError,

        // Chat
        Chat_InvalidMode,
        Chat_InvalidChannel,
        Chat_AnonymousMessagesDisabled,
        Chat_PrivateMessagesDisabled,

        // Rooms
        Rooms_NotFound,

        // Permissions
        Permissions_PermissionKeyNotFound,
        Permissions_InvalidPermissionValueType,

        // Equipment
        Equipment_NotFound,
        Equipment_InvalidToken,
        Equipment_NotInitialized,
        Equipment_ParticipantNotJoined,

        // Scenes
        Scenes_RoomNotFound,
        Scenes_Invalid,

        // Breakout Rooms
        BreakoutRoom_AlreadyOpen,
        BreakoutRoom_NotOpen,
        BreakoutRoom_AssigningParticipantsFailed,
    }
}
