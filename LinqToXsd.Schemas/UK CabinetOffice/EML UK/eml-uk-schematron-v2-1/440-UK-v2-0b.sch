<?xml version="1.0"?>
<schema xmlns="http://www.ascc.net/xml/schematron">
	<title>EML-UK 440-Cast Vote</title>
	<ns prefix="eml" uri="urn:oasis:names:tc:evs:schema:eml"/>
	<ns prefix="apd" uri="http://www.govtalk.gov.uk/people/AddressAndPersonalDetails"/>
	<ns prefix="bs7666" uri="http://www.govtalk.gov.uk/people/bs7666"/>

	<pattern name="eml">
		<rule context="eml:AuditInformation/eml:ProcessingUnits">
			<assert id="3000-001" test="*[@Role='sender']">If there are processing units in the AuditInformation, one must have the role of sender</assert>
			<assert id="3000-002" test="*[@Role='receiver']">If there are processing units in the AuditInformation, one must have the role of receiver</assert>
		</rule>
		<rule context="eml:EML">
			<report id="3000-003" test="eml:SequenceNumber or eml:NumberInSequence or eml:SequencedElementName">This message must not contain the elements used for splitting</report>
			<assert id="3000-004" test="@Id='440'">The value of the Id attribute of the EML element is incorrect</assert>
			<assert id="3000-005" test="eml:CastVote">The message type must match the Id attribute of the EML element</assert>
		</rule>
	</pattern>
	
	<pattern name="eml-uk">
		<rule context="eml:EML">
			<assert id="4000-001" test="eml:Seal">A Seal must be present</assert>
			<report id="4000-002" test="//eml:ElectionRuleId">The election rule ID is not used</report>
			<assert id="4000-101" test="*/eml:AuditInformation/eml:ProcessingUnits/*">AuditInformation is mandatory and must have at least one ProcessingUnit</assert>
			<assert id="4000-102" test="eml:RequestedResponseLanguage">This message must indicate the language for the response</assert>
		</rule>
		<rule context="eml:OtherSeal">
			<assert id="4000-003" test="@Type='RFC2630' or @Type='RFC3161'">If a seal is of type OtherSeal, the Type attribute must have a value of RFC2630 or RFC3161</assert>
		</rule>
		<rule context="eml:Contact">
			<assert id="4000-004" test="*">There must be at least one child of a contact element</assert>
		</rule>
		<rule context="eml:*[contains(name(),'ddress') and not(name()='apd:IntAddressLine')]">
			<assert id="4000-005" test="bs7666:PostCode or bs7666:UniquePropertyReferenceNumber or apd:InternationalPostCode">The address must contain either a UPRN (if it is a BS7666 address) or a post code (or both)</assert>
		</rule>
	</pattern>
	
	<pattern name="eml-440">
	</pattern>

	<pattern name="eml-440-uk">
		<rule context="eml:Selection">
			<report id="4440-001" test="eml:WriteinCandidateName">Write in candidates are not allowed</report>
			<report id="4440-002" test="@ShortCode and *">If Selection has a ShortCode attribute, it should not have child elements</report>
			<assert id="4440-003" test="eml:PersonalIdentifier or /eml:EML/eml:CastVote/eml:VToken or /eml:EML/eml:CastVote/eml:VTokenQualified">If there is no VToken or VTokenQualified, every Selection element must have a PersonalIdentifier child</assert>
		</rule>
		<rule context="eml:CastVote">
			<assert id="4440-004" test="eml:AuditInformation/eml:VotingChannel">VotingChannel is mandatory in the AuditInformation</assert>
		</rule>
	</pattern>
</schema>
