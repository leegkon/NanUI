// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.



namespace Chromium.Remote
{
	internal enum RemoteCallId : ushort {
        CfxRuntimeCurrentlyOnRenderProcessCall,
        CfxRuntimeFormatUrlForSecurityDisplayRenderProcessCall,
        CfxRuntimePostDelayedTaskRenderProcessCall,
        CfxRuntimePostTaskRenderProcessCall,
        CfxRuntimeRegisterExtensionRenderProcessCall,
        CfxAppCtorRenderProcessCall,
        CfxOnBeforeCommandLineProcessingBrowserProcessCall,
        CfxOnBeforeCommandLineProcessingActivateRenderProcessCall,
        CfxOnBeforeCommandLineProcessingDeactivateRenderProcessCall,
        CfxOnBeforeCommandLineProcessingGetProcessTypeRenderProcessCall,
        CfxOnBeforeCommandLineProcessingGetCommandLineRenderProcessCall,
        CfxOnRegisterCustomSchemesBrowserProcessCall,
        CfxOnRegisterCustomSchemesActivateRenderProcessCall,
        CfxOnRegisterCustomSchemesDeactivateRenderProcessCall,
        CfxOnRegisterCustomSchemesGetRegistrarRenderProcessCall,
        CfxGetResourceBundleHandlerBrowserProcessCall,
        CfxGetResourceBundleHandlerActivateRenderProcessCall,
        CfxGetResourceBundleHandlerDeactivateRenderProcessCall,
        CfxGetResourceBundleHandlerSetReturnValueRenderProcessCall,
        CfxGetRenderProcessHandlerBrowserProcessCall,
        CfxGetRenderProcessHandlerActivateRenderProcessCall,
        CfxGetRenderProcessHandlerDeactivateRenderProcessCall,
        CfxGetRenderProcessHandlerSetReturnValueRenderProcessCall,
        CfxBinaryValueCreateRenderProcessCall,
        CfxBinaryValueIsValidRenderProcessCall,
        CfxBinaryValueIsOwnedRenderProcessCall,
        CfxBinaryValueIsSameRenderProcessCall,
        CfxBinaryValueIsEqualRenderProcessCall,
        CfxBinaryValueCopyRenderProcessCall,
        CfxBinaryValueGetSizeRenderProcessCall,
        CfxBinaryValueGetDataRenderProcessCall,
        CfxBrowserCanGoBackRenderProcessCall,
        CfxBrowserGoBackRenderProcessCall,
        CfxBrowserCanGoForwardRenderProcessCall,
        CfxBrowserGoForwardRenderProcessCall,
        CfxBrowserIsLoadingRenderProcessCall,
        CfxBrowserReloadRenderProcessCall,
        CfxBrowserReloadIgnoreCacheRenderProcessCall,
        CfxBrowserStopLoadRenderProcessCall,
        CfxBrowserGetIdentifierRenderProcessCall,
        CfxBrowserIsSameRenderProcessCall,
        CfxBrowserIsPopupRenderProcessCall,
        CfxBrowserHasDocumentRenderProcessCall,
        CfxBrowserGetMainFrameRenderProcessCall,
        CfxBrowserGetFocusedFrameRenderProcessCall,
        CfxBrowserGetFrameByIdentifierRenderProcessCall,
        CfxBrowserGetFrameRenderProcessCall,
        CfxBrowserGetFrameCountRenderProcessCall,
        CfxBrowserGetFrameIdentifiersRenderProcessCall,
        CfxBrowserGetFrameNamesRenderProcessCall,
        CfxBrowserSendProcessMessageRenderProcessCall,
        CfxCommandLineCreateRenderProcessCall,
        CfxCommandLineGetGlobalRenderProcessCall,
        CfxCommandLineIsValidRenderProcessCall,
        CfxCommandLineIsReadOnlyRenderProcessCall,
        CfxCommandLineCopyRenderProcessCall,
        CfxCommandLineInitFromArgvRenderProcessCall,
        CfxCommandLineInitFromStringRenderProcessCall,
        CfxCommandLineResetRenderProcessCall,
        CfxCommandLineGetArgvRenderProcessCall,
        CfxCommandLineGetCommandLineStringRenderProcessCall,
        CfxCommandLineGetProgramRenderProcessCall,
        CfxCommandLineSetProgramRenderProcessCall,
        CfxCommandLineHasSwitchesRenderProcessCall,
        CfxCommandLineHasSwitchRenderProcessCall,
        CfxCommandLineGetSwitchValueRenderProcessCall,
        CfxCommandLineGetSwitchesRenderProcessCall,
        CfxCommandLineAppendSwitchRenderProcessCall,
        CfxCommandLineAppendSwitchWithValueRenderProcessCall,
        CfxCommandLineHasArgumentsRenderProcessCall,
        CfxCommandLineGetArgumentsRenderProcessCall,
        CfxCommandLineAppendArgumentRenderProcessCall,
        CfxCommandLinePrependWrapperRenderProcessCall,
        CfxDictionaryValueCreateRenderProcessCall,
        CfxDictionaryValueIsValidRenderProcessCall,
        CfxDictionaryValueIsOwnedRenderProcessCall,
        CfxDictionaryValueIsReadOnlyRenderProcessCall,
        CfxDictionaryValueIsSameRenderProcessCall,
        CfxDictionaryValueIsEqualRenderProcessCall,
        CfxDictionaryValueCopyRenderProcessCall,
        CfxDictionaryValueGetSizeRenderProcessCall,
        CfxDictionaryValueClearRenderProcessCall,
        CfxDictionaryValueHasKeyRenderProcessCall,
        CfxDictionaryValueGetKeysRenderProcessCall,
        CfxDictionaryValueRemoveRenderProcessCall,
        CfxDictionaryValueGetTypeRenderProcessCall,
        CfxDictionaryValueGetValueRenderProcessCall,
        CfxDictionaryValueGetBoolRenderProcessCall,
        CfxDictionaryValueGetIntRenderProcessCall,
        CfxDictionaryValueGetDoubleRenderProcessCall,
        CfxDictionaryValueGetStringRenderProcessCall,
        CfxDictionaryValueGetBinaryRenderProcessCall,
        CfxDictionaryValueGetDictionaryRenderProcessCall,
        CfxDictionaryValueGetListRenderProcessCall,
        CfxDictionaryValueSetValueRenderProcessCall,
        CfxDictionaryValueSetNullRenderProcessCall,
        CfxDictionaryValueSetBoolRenderProcessCall,
        CfxDictionaryValueSetIntRenderProcessCall,
        CfxDictionaryValueSetDoubleRenderProcessCall,
        CfxDictionaryValueSetStringRenderProcessCall,
        CfxDictionaryValueSetBinaryRenderProcessCall,
        CfxDictionaryValueSetDictionaryRenderProcessCall,
        CfxDictionaryValueSetListRenderProcessCall,
        CfxDomDocumentGetTypeRenderProcessCall,
        CfxDomDocumentGetDocumentRenderProcessCall,
        CfxDomDocumentGetBodyRenderProcessCall,
        CfxDomDocumentGetHeadRenderProcessCall,
        CfxDomDocumentGetTitleRenderProcessCall,
        CfxDomDocumentGetElementByIdRenderProcessCall,
        CfxDomDocumentGetFocusedNodeRenderProcessCall,
        CfxDomDocumentHasSelectionRenderProcessCall,
        CfxDomDocumentGetSelectionStartOffsetRenderProcessCall,
        CfxDomDocumentGetSelectionEndOffsetRenderProcessCall,
        CfxDomDocumentGetSelectionAsMarkupRenderProcessCall,
        CfxDomDocumentGetSelectionAsTextRenderProcessCall,
        CfxDomDocumentGetBaseUrlRenderProcessCall,
        CfxDomDocumentGetCompleteUrlRenderProcessCall,
        CfxDomNodeGetTypeRenderProcessCall,
        CfxDomNodeIsTextRenderProcessCall,
        CfxDomNodeIsElementRenderProcessCall,
        CfxDomNodeIsEditableRenderProcessCall,
        CfxDomNodeIsFormControlElementRenderProcessCall,
        CfxDomNodeGetFormControlElementTypeRenderProcessCall,
        CfxDomNodeIsSameRenderProcessCall,
        CfxDomNodeGetNameRenderProcessCall,
        CfxDomNodeGetValueRenderProcessCall,
        CfxDomNodeSetValueRenderProcessCall,
        CfxDomNodeGetAsMarkupRenderProcessCall,
        CfxDomNodeGetDocumentRenderProcessCall,
        CfxDomNodeGetParentRenderProcessCall,
        CfxDomNodeGetPreviousSiblingRenderProcessCall,
        CfxDomNodeGetNextSiblingRenderProcessCall,
        CfxDomNodeHasChildrenRenderProcessCall,
        CfxDomNodeGetFirstChildRenderProcessCall,
        CfxDomNodeGetLastChildRenderProcessCall,
        CfxDomNodeGetElementTagNameRenderProcessCall,
        CfxDomNodeHasElementAttributesRenderProcessCall,
        CfxDomNodeHasElementAttributeRenderProcessCall,
        CfxDomNodeGetElementAttributeRenderProcessCall,
        CfxDomNodeGetElementAttributesRenderProcessCall,
        CfxDomNodeSetElementAttributeRenderProcessCall,
        CfxDomNodeGetElementInnerTextRenderProcessCall,
        CfxDomVisitorCtorRenderProcessCall,
        CfxDomVisitorVisitBrowserProcessCall,
        CfxDomVisitorVisitActivateRenderProcessCall,
        CfxDomVisitorVisitDeactivateRenderProcessCall,
        CfxDomVisitorVisitGetDocumentRenderProcessCall,
        CfxFrameIsValidRenderProcessCall,
        CfxFrameUndoRenderProcessCall,
        CfxFrameRedoRenderProcessCall,
        CfxFrameCutRenderProcessCall,
        CfxFrameCopyRenderProcessCall,
        CfxFramePasteRenderProcessCall,
        CfxFrameDelRenderProcessCall,
        CfxFrameSelectAllRenderProcessCall,
        CfxFrameGetSourceRenderProcessCall,
        CfxFrameGetTextRenderProcessCall,
        CfxFrameLoadRequestRenderProcessCall,
        CfxFrameLoadUrlRenderProcessCall,
        CfxFrameLoadStringRenderProcessCall,
        CfxFrameExecuteJavaScriptRenderProcessCall,
        CfxFrameIsMainRenderProcessCall,
        CfxFrameIsFocusedRenderProcessCall,
        CfxFrameGetNameRenderProcessCall,
        CfxFrameGetIdentifierRenderProcessCall,
        CfxFrameGetParentRenderProcessCall,
        CfxFrameGetUrlRenderProcessCall,
        CfxFrameGetBrowserRenderProcessCall,
        CfxFrameGetV8ContextRenderProcessCall,
        CfxFrameVisitDomRenderProcessCall,
        CfxListValueCreateRenderProcessCall,
        CfxListValueIsValidRenderProcessCall,
        CfxListValueIsOwnedRenderProcessCall,
        CfxListValueIsReadOnlyRenderProcessCall,
        CfxListValueIsSameRenderProcessCall,
        CfxListValueIsEqualRenderProcessCall,
        CfxListValueCopyRenderProcessCall,
        CfxListValueSetSizeRenderProcessCall,
        CfxListValueGetSizeRenderProcessCall,
        CfxListValueClearRenderProcessCall,
        CfxListValueRemoveRenderProcessCall,
        CfxListValueGetTypeRenderProcessCall,
        CfxListValueGetValueRenderProcessCall,
        CfxListValueGetBoolRenderProcessCall,
        CfxListValueGetIntRenderProcessCall,
        CfxListValueGetDoubleRenderProcessCall,
        CfxListValueGetStringRenderProcessCall,
        CfxListValueGetBinaryRenderProcessCall,
        CfxListValueGetDictionaryRenderProcessCall,
        CfxListValueGetListRenderProcessCall,
        CfxListValueSetValueRenderProcessCall,
        CfxListValueSetNullRenderProcessCall,
        CfxListValueSetBoolRenderProcessCall,
        CfxListValueSetIntRenderProcessCall,
        CfxListValueSetDoubleRenderProcessCall,
        CfxListValueSetStringRenderProcessCall,
        CfxListValueSetBinaryRenderProcessCall,
        CfxListValueSetDictionaryRenderProcessCall,
        CfxListValueSetListRenderProcessCall,
        CfxLoadHandlerCtorRenderProcessCall,
        CfxOnLoadingStateChangeBrowserProcessCall,
        CfxOnLoadingStateChangeActivateRenderProcessCall,
        CfxOnLoadingStateChangeDeactivateRenderProcessCall,
        CfxOnLoadingStateChangeGetBrowserRenderProcessCall,
        CfxOnLoadingStateChangeGetIsLoadingRenderProcessCall,
        CfxOnLoadingStateChangeGetCanGoBackRenderProcessCall,
        CfxOnLoadingStateChangeGetCanGoForwardRenderProcessCall,
        CfxOnLoadStartBrowserProcessCall,
        CfxOnLoadStartActivateRenderProcessCall,
        CfxOnLoadStartDeactivateRenderProcessCall,
        CfxOnLoadStartGetBrowserRenderProcessCall,
        CfxOnLoadStartGetFrameRenderProcessCall,
        CfxOnLoadEndBrowserProcessCall,
        CfxOnLoadEndActivateRenderProcessCall,
        CfxOnLoadEndDeactivateRenderProcessCall,
        CfxOnLoadEndGetBrowserRenderProcessCall,
        CfxOnLoadEndGetFrameRenderProcessCall,
        CfxOnLoadEndGetHttpStatusCodeRenderProcessCall,
        CfxOnLoadErrorBrowserProcessCall,
        CfxOnLoadErrorActivateRenderProcessCall,
        CfxOnLoadErrorDeactivateRenderProcessCall,
        CfxOnLoadErrorGetBrowserRenderProcessCall,
        CfxOnLoadErrorGetFrameRenderProcessCall,
        CfxOnLoadErrorGetErrorCodeRenderProcessCall,
        CfxOnLoadErrorGetErrorTextRenderProcessCall,
        CfxOnLoadErrorGetFailedUrlRenderProcessCall,
        CfxPostDataCreateRenderProcessCall,
        CfxPostDataIsReadOnlyRenderProcessCall,
        CfxPostDataHasExcludedElementsRenderProcessCall,
        CfxPostDataGetElementCountRenderProcessCall,
        CfxPostDataGetElementsRenderProcessCall,
        CfxPostDataRemoveElementRenderProcessCall,
        CfxPostDataAddElementRenderProcessCall,
        CfxPostDataRemoveElementsRenderProcessCall,
        CfxPostDataElementCreateRenderProcessCall,
        CfxPostDataElementIsReadOnlyRenderProcessCall,
        CfxPostDataElementSetToEmptyRenderProcessCall,
        CfxPostDataElementSetToFileRenderProcessCall,
        CfxPostDataElementSetToBytesRenderProcessCall,
        CfxPostDataElementGetTypeRenderProcessCall,
        CfxPostDataElementGetFileRenderProcessCall,
        CfxPostDataElementGetBytesCountRenderProcessCall,
        CfxPostDataElementGetBytesRenderProcessCall,
        CfxProcessMessageCreateRenderProcessCall,
        CfxProcessMessageIsValidRenderProcessCall,
        CfxProcessMessageIsReadOnlyRenderProcessCall,
        CfxProcessMessageCopyRenderProcessCall,
        CfxProcessMessageGetNameRenderProcessCall,
        CfxProcessMessageGetArgumentListRenderProcessCall,
        CfxRenderProcessHandlerCtorRenderProcessCall,
        CfxOnRenderThreadCreatedBrowserProcessCall,
        CfxOnRenderThreadCreatedActivateRenderProcessCall,
        CfxOnRenderThreadCreatedDeactivateRenderProcessCall,
        CfxOnRenderThreadCreatedGetExtraInfoRenderProcessCall,
        CfxOnWebKitInitializedBrowserProcessCall,
        CfxOnWebKitInitializedActivateRenderProcessCall,
        CfxOnWebKitInitializedDeactivateRenderProcessCall,
        CfxOnBrowserCreatedBrowserProcessCall,
        CfxOnBrowserCreatedActivateRenderProcessCall,
        CfxOnBrowserCreatedDeactivateRenderProcessCall,
        CfxOnBrowserCreatedGetBrowserRenderProcessCall,
        CfxOnBrowserDestroyedBrowserProcessCall,
        CfxOnBrowserDestroyedActivateRenderProcessCall,
        CfxOnBrowserDestroyedDeactivateRenderProcessCall,
        CfxOnBrowserDestroyedGetBrowserRenderProcessCall,
        CfxGetLoadHandlerBrowserProcessCall,
        CfxGetLoadHandlerActivateRenderProcessCall,
        CfxGetLoadHandlerDeactivateRenderProcessCall,
        CfxGetLoadHandlerSetReturnValueRenderProcessCall,
        CfxOnBeforeNavigationBrowserProcessCall,
        CfxOnBeforeNavigationActivateRenderProcessCall,
        CfxOnBeforeNavigationDeactivateRenderProcessCall,
        CfxOnBeforeNavigationGetBrowserRenderProcessCall,
        CfxOnBeforeNavigationGetFrameRenderProcessCall,
        CfxOnBeforeNavigationGetRequestRenderProcessCall,
        CfxOnBeforeNavigationGetNavigationTypeRenderProcessCall,
        CfxOnBeforeNavigationGetIsRedirectRenderProcessCall,
        CfxOnBeforeNavigationSetReturnValueRenderProcessCall,
        CfxOnContextCreatedBrowserProcessCall,
        CfxOnContextCreatedActivateRenderProcessCall,
        CfxOnContextCreatedDeactivateRenderProcessCall,
        CfxOnContextCreatedGetBrowserRenderProcessCall,
        CfxOnContextCreatedGetFrameRenderProcessCall,
        CfxOnContextCreatedGetContextRenderProcessCall,
        CfxOnContextReleasedBrowserProcessCall,
        CfxOnContextReleasedActivateRenderProcessCall,
        CfxOnContextReleasedDeactivateRenderProcessCall,
        CfxOnContextReleasedGetBrowserRenderProcessCall,
        CfxOnContextReleasedGetFrameRenderProcessCall,
        CfxOnContextReleasedGetContextRenderProcessCall,
        CfxOnUncaughtExceptionBrowserProcessCall,
        CfxOnUncaughtExceptionActivateRenderProcessCall,
        CfxOnUncaughtExceptionDeactivateRenderProcessCall,
        CfxOnUncaughtExceptionGetBrowserRenderProcessCall,
        CfxOnUncaughtExceptionGetFrameRenderProcessCall,
        CfxOnUncaughtExceptionGetContextRenderProcessCall,
        CfxOnUncaughtExceptionGetExceptionRenderProcessCall,
        CfxOnUncaughtExceptionGetStackTraceRenderProcessCall,
        CfxOnFocusedNodeChangedBrowserProcessCall,
        CfxOnFocusedNodeChangedActivateRenderProcessCall,
        CfxOnFocusedNodeChangedDeactivateRenderProcessCall,
        CfxOnFocusedNodeChangedGetBrowserRenderProcessCall,
        CfxOnFocusedNodeChangedGetFrameRenderProcessCall,
        CfxOnFocusedNodeChangedGetNodeRenderProcessCall,
        CfxOnProcessMessageReceivedBrowserProcessCall,
        CfxOnProcessMessageReceivedActivateRenderProcessCall,
        CfxOnProcessMessageReceivedDeactivateRenderProcessCall,
        CfxOnProcessMessageReceivedGetBrowserRenderProcessCall,
        CfxOnProcessMessageReceivedGetSourceProcessRenderProcessCall,
        CfxOnProcessMessageReceivedGetMessageRenderProcessCall,
        CfxOnProcessMessageReceivedSetReturnValueRenderProcessCall,
        CfxRequestCreateRenderProcessCall,
        CfxRequestIsReadOnlyRenderProcessCall,
        CfxRequestGetUrlRenderProcessCall,
        CfxRequestSetUrlRenderProcessCall,
        CfxRequestGetMethodRenderProcessCall,
        CfxRequestSetMethodRenderProcessCall,
        CfxRequestSetReferrerRenderProcessCall,
        CfxRequestGetReferrerUrlRenderProcessCall,
        CfxRequestGetReferrerPolicyRenderProcessCall,
        CfxRequestGetPostDataRenderProcessCall,
        CfxRequestSetPostDataRenderProcessCall,
        CfxRequestGetHeaderMapRenderProcessCall,
        CfxRequestSetHeaderMapRenderProcessCall,
        CfxRequestSetRenderProcessCall,
        CfxRequestGetFlagsRenderProcessCall,
        CfxRequestSetFlagsRenderProcessCall,
        CfxRequestGetFirstPartyForCookiesRenderProcessCall,
        CfxRequestSetFirstPartyForCookiesRenderProcessCall,
        CfxRequestGetResourceTypeRenderProcessCall,
        CfxRequestGetTransitionTypeRenderProcessCall,
        CfxRequestGetIdentifierRenderProcessCall,
        CfxResourceBundleHandlerCtorRenderProcessCall,
        CfxGetLocalizedStringBrowserProcessCall,
        CfxGetLocalizedStringActivateRenderProcessCall,
        CfxGetLocalizedStringDeactivateRenderProcessCall,
        CfxGetLocalizedStringGetStringIdRenderProcessCall,
        CfxGetLocalizedStringSetStringRenderProcessCall,
        CfxGetLocalizedStringGetStringRenderProcessCall,
        CfxGetLocalizedStringSetReturnValueRenderProcessCall,
        CfxGetDataResourceBrowserProcessCall,
        CfxGetDataResourceActivateRenderProcessCall,
        CfxGetDataResourceDeactivateRenderProcessCall,
        CfxGetDataResourceGetResourceIdRenderProcessCall,
        CfxGetDataResourceSetDataRenderProcessCall,
        CfxGetDataResourceSetDataSizeRenderProcessCall,
        CfxGetDataResourceSetReturnValueRenderProcessCall,
        CfxGetDataResourceForScaleBrowserProcessCall,
        CfxGetDataResourceForScaleActivateRenderProcessCall,
        CfxGetDataResourceForScaleDeactivateRenderProcessCall,
        CfxGetDataResourceForScaleGetResourceIdRenderProcessCall,
        CfxGetDataResourceForScaleGetScaleFactorRenderProcessCall,
        CfxGetDataResourceForScaleSetDataRenderProcessCall,
        CfxGetDataResourceForScaleSetDataSizeRenderProcessCall,
        CfxGetDataResourceForScaleSetReturnValueRenderProcessCall,
        CfxSchemeRegistrarAddCustomSchemeRenderProcessCall,
        CfxStringVisitorCtorRenderProcessCall,
        CfxStringVisitorVisitBrowserProcessCall,
        CfxStringVisitorVisitActivateRenderProcessCall,
        CfxStringVisitorVisitDeactivateRenderProcessCall,
        CfxStringVisitorVisitGetStringRenderProcessCall,
        CfxTaskCtorRenderProcessCall,
        CfxTaskExecuteBrowserProcessCall,
        CfxTaskExecuteActivateRenderProcessCall,
        CfxTaskExecuteDeactivateRenderProcessCall,
        CfxTaskRunnerGetForCurrentThreadRenderProcessCall,
        CfxTaskRunnerGetForThreadRenderProcessCall,
        CfxTaskRunnerIsSameRenderProcessCall,
        CfxTaskRunnerBelongsToCurrentThreadRenderProcessCall,
        CfxTaskRunnerBelongsToThreadRenderProcessCall,
        CfxTaskRunnerPostTaskRenderProcessCall,
        CfxTaskRunnerPostDelayedTaskRenderProcessCall,
        CfxTimeCtorRenderProcessCall,
        CfxTimeGetYearRenderProcessCall,
        CfxTimeSetYearRenderProcessCall,
        CfxTimeGetMonthRenderProcessCall,
        CfxTimeSetMonthRenderProcessCall,
        CfxTimeGetDayOfWeekRenderProcessCall,
        CfxTimeSetDayOfWeekRenderProcessCall,
        CfxTimeGetDayOfMonthRenderProcessCall,
        CfxTimeSetDayOfMonthRenderProcessCall,
        CfxTimeGetHourRenderProcessCall,
        CfxTimeSetHourRenderProcessCall,
        CfxTimeGetMinuteRenderProcessCall,
        CfxTimeSetMinuteRenderProcessCall,
        CfxTimeGetSecondRenderProcessCall,
        CfxTimeSetSecondRenderProcessCall,
        CfxTimeGetMillisecondRenderProcessCall,
        CfxTimeSetMillisecondRenderProcessCall,
        CfxV8AccessorCtorRenderProcessCall,
        CfxV8AccessorGetBrowserProcessCall,
        CfxV8AccessorGetActivateRenderProcessCall,
        CfxV8AccessorGetDeactivateRenderProcessCall,
        CfxV8AccessorGetGetNameRenderProcessCall,
        CfxV8AccessorGetGetObjectRenderProcessCall,
        CfxV8AccessorGetSetRetvalRenderProcessCall,
        CfxV8AccessorGetSetExceptionRenderProcessCall,
        CfxV8AccessorGetGetExceptionRenderProcessCall,
        CfxV8AccessorGetSetReturnValueRenderProcessCall,
        CfxV8AccessorSetBrowserProcessCall,
        CfxV8AccessorSetActivateRenderProcessCall,
        CfxV8AccessorSetDeactivateRenderProcessCall,
        CfxV8AccessorSetGetNameRenderProcessCall,
        CfxV8AccessorSetGetObjectRenderProcessCall,
        CfxV8AccessorSetGetValueRenderProcessCall,
        CfxV8AccessorSetSetExceptionRenderProcessCall,
        CfxV8AccessorSetGetExceptionRenderProcessCall,
        CfxV8AccessorSetSetReturnValueRenderProcessCall,
        CfxV8ContextGetCurrentContextRenderProcessCall,
        CfxV8ContextGetEnteredContextRenderProcessCall,
        CfxV8ContextInContextRenderProcessCall,
        CfxV8ContextGetTaskRunnerRenderProcessCall,
        CfxV8ContextIsValidRenderProcessCall,
        CfxV8ContextGetBrowserRenderProcessCall,
        CfxV8ContextGetFrameRenderProcessCall,
        CfxV8ContextGetGlobalRenderProcessCall,
        CfxV8ContextEnterRenderProcessCall,
        CfxV8ContextExitRenderProcessCall,
        CfxV8ContextIsSameRenderProcessCall,
        CfxV8ContextEvalRenderProcessCall,
        CfxV8ExceptionGetMessageRenderProcessCall,
        CfxV8ExceptionGetSourceLineRenderProcessCall,
        CfxV8ExceptionGetScriptResourceNameRenderProcessCall,
        CfxV8ExceptionGetLineNumberRenderProcessCall,
        CfxV8ExceptionGetStartPositionRenderProcessCall,
        CfxV8ExceptionGetEndPositionRenderProcessCall,
        CfxV8ExceptionGetStartColumnRenderProcessCall,
        CfxV8ExceptionGetEndColumnRenderProcessCall,
        CfxV8HandlerCtorRenderProcessCall,
        CfxV8HandlerExecuteBrowserProcessCall,
        CfxV8HandlerExecuteActivateRenderProcessCall,
        CfxV8HandlerExecuteDeactivateRenderProcessCall,
        CfxV8HandlerExecuteGetNameRenderProcessCall,
        CfxV8HandlerExecuteGetObjectRenderProcessCall,
        CfxV8HandlerExecuteGetArgumentsRenderProcessCall,
        CfxV8HandlerExecuteSetExceptionRenderProcessCall,
        CfxV8HandlerExecuteSetReturnValueRenderProcessCall,
        CfxV8StackFrameIsValidRenderProcessCall,
        CfxV8StackFrameGetScriptNameRenderProcessCall,
        CfxV8StackFrameGetScriptNameOrSourceUrlRenderProcessCall,
        CfxV8StackFrameGetFunctionNameRenderProcessCall,
        CfxV8StackFrameGetLineNumberRenderProcessCall,
        CfxV8StackFrameGetColumnRenderProcessCall,
        CfxV8StackFrameIsEvalRenderProcessCall,
        CfxV8StackFrameIsConstructorRenderProcessCall,
        CfxV8StackTraceGetCurrentRenderProcessCall,
        CfxV8StackTraceIsValidRenderProcessCall,
        CfxV8StackTraceGetFrameCountRenderProcessCall,
        CfxV8StackTraceGetFrameRenderProcessCall,
        CfxV8ValueCreateUndefinedRenderProcessCall,
        CfxV8ValueCreateNullRenderProcessCall,
        CfxV8ValueCreateBoolRenderProcessCall,
        CfxV8ValueCreateIntRenderProcessCall,
        CfxV8ValueCreateUintRenderProcessCall,
        CfxV8ValueCreateDoubleRenderProcessCall,
        CfxV8ValueCreateDateRenderProcessCall,
        CfxV8ValueCreateStringRenderProcessCall,
        CfxV8ValueCreateObjectRenderProcessCall,
        CfxV8ValueCreateArrayRenderProcessCall,
        CfxV8ValueCreateFunctionRenderProcessCall,
        CfxV8ValueIsValidRenderProcessCall,
        CfxV8ValueIsUndefinedRenderProcessCall,
        CfxV8ValueIsNullRenderProcessCall,
        CfxV8ValueIsBoolRenderProcessCall,
        CfxV8ValueIsIntRenderProcessCall,
        CfxV8ValueIsUintRenderProcessCall,
        CfxV8ValueIsDoubleRenderProcessCall,
        CfxV8ValueIsDateRenderProcessCall,
        CfxV8ValueIsStringRenderProcessCall,
        CfxV8ValueIsObjectRenderProcessCall,
        CfxV8ValueIsArrayRenderProcessCall,
        CfxV8ValueIsFunctionRenderProcessCall,
        CfxV8ValueIsSameRenderProcessCall,
        CfxV8ValueGetBoolValueRenderProcessCall,
        CfxV8ValueGetIntValueRenderProcessCall,
        CfxV8ValueGetUintValueRenderProcessCall,
        CfxV8ValueGetDoubleValueRenderProcessCall,
        CfxV8ValueGetDateValueRenderProcessCall,
        CfxV8ValueGetStringValueRenderProcessCall,
        CfxV8ValueIsUserCreatedRenderProcessCall,
        CfxV8ValueHasExceptionRenderProcessCall,
        CfxV8ValueGetExceptionRenderProcessCall,
        CfxV8ValueClearExceptionRenderProcessCall,
        CfxV8ValueWillRethrowExceptionsRenderProcessCall,
        CfxV8ValueSetRethrowExceptionsRenderProcessCall,
        CfxV8ValueHasValueByKeyRenderProcessCall,
        CfxV8ValueHasValueByIndexRenderProcessCall,
        CfxV8ValueDeleteValueByKeyRenderProcessCall,
        CfxV8ValueDeleteValueByIndexRenderProcessCall,
        CfxV8ValueGetValueByKeyRenderProcessCall,
        CfxV8ValueGetValueByIndexRenderProcessCall,
        CfxV8ValueSetValueByKeyRenderProcessCall,
        CfxV8ValueSetValueByIndexRenderProcessCall,
        CfxV8ValueSetValueByAccessorRenderProcessCall,
        CfxV8ValueGetKeysRenderProcessCall,
        CfxV8ValueSetUserDataRenderProcessCall,
        CfxV8ValueGetUserDataRenderProcessCall,
        CfxV8ValueGetExternallyAllocatedMemoryRenderProcessCall,
        CfxV8ValueAdjustExternallyAllocatedMemoryRenderProcessCall,
        CfxV8ValueGetArrayLengthRenderProcessCall,
        CfxV8ValueGetFunctionNameRenderProcessCall,
        CfxV8ValueGetFunctionHandlerRenderProcessCall,
        CfxV8ValueExecuteFunctionRenderProcessCall,
        CfxV8ValueExecuteFunctionWithContextRenderProcessCall,
        CfxValueCreateRenderProcessCall,
        CfxValueIsValidRenderProcessCall,
        CfxValueIsOwnedRenderProcessCall,
        CfxValueIsReadOnlyRenderProcessCall,
        CfxValueIsSameRenderProcessCall,
        CfxValueIsEqualRenderProcessCall,
        CfxValueCopyRenderProcessCall,
        CfxValueGetTypeRenderProcessCall,
        CfxValueGetBoolRenderProcessCall,
        CfxValueGetIntRenderProcessCall,
        CfxValueGetDoubleRenderProcessCall,
        CfxValueGetStringRenderProcessCall,
        CfxValueGetBinaryRenderProcessCall,
        CfxValueGetDictionaryRenderProcessCall,
        CfxValueGetListRenderProcessCall,
        CfxValueSetNullRenderProcessCall,
        CfxValueSetBoolRenderProcessCall,
        CfxValueSetIntRenderProcessCall,
        CfxValueSetDoubleRenderProcessCall,
        CfxValueSetStringRenderProcessCall,
        CfxValueSetBinaryRenderProcessCall,
        CfxValueSetDictionaryRenderProcessCall,
        CfxValueSetListRenderProcessCall,
        ExecuteRemoteProcessRemoteCall,
        ReleaseProxyRemoteCall,
        CfrMarshalAllocHGlobalRenderProcessCall,
        CfrMarshalFreeHGlobalRenderProcessCall,
        CfrMarshalCopyToNativeRenderProcessCall,
        CfrMarshalCopyToManagedRenderProcessCall,
        CfxBinaryValueCreateFromArrayRenderProcessCall,
        CfxRuntimeExecuteProcessRenderProcessCall
    }
}
