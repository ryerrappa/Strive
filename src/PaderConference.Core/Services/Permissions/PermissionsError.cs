﻿using PaderConference.Core.Dto;

namespace PaderConference.Core.Services.Permissions
{
    public static class PermissionsError
    {
        public static Error PermissionKeyNotFound =>
            new ServiceError("The permission key was not found.", ServiceErrorCode.Permissions_PermissionKeyNotFound);

        public static Error PermissionDeniedGiveTemporaryPermission =>
            new ServiceError("Permission denied to give temporary permission.",
                ServiceErrorCode.Permissions_DeniedGiveTemporaryPermission);

        public static Error PermissionDeniedFetchParticipantsPermissions =>
            new ServiceError("Permission denied when trying to fetch the permissions of another participant.",
                ServiceErrorCode.Permissions_DeniedFetchingParticipantsPermissions);

        public static Error InvalidPermissionValueType =>
            new ServiceError("The type of the value does not match the permission definition.",
                ServiceErrorCode.Permissions_InvalidPermissionValueType);
    }
}
