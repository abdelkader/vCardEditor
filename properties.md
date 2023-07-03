<h3>Already implemented &#9989; </h3>
<table>
    <tr>
        <td rowspan="2"><b>Name</b></td>
        <td colspan="3"><b>Property presence</b></td>
        <td rowspan="2"><b>Description</b></td>
        <td rowspan="2"><b>Example</b></td>
    </tr>
    <tr>
        <td><b>v. 2.1</b></td>
        <td><b>v. 3.0</b></td>
        <td><b>v. 4.0</b></td>
    </tr>
    <tr>
        <td>ADR</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>A structured representation of the physical delivery address for the vCard object.</td>
        <td>ADR;TYPE=home:;;123 Main St.;Springfield;IL;12345;USA</td>
    </tr>
    <tr>
        <td>BEGIN</td>
        <td>Required</td>
        <td>Required</td>
        <td>Required</td>
        <td>All vCards must start with this property.</td>
        <td>BEGIN:VCARD</td>
    </tr>
    <tr>
        <td>EMAIL</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>The address for electronic mail communication with the vCard object.</td>
        <td>EMAIL:johndoe@hotmail.com</td>
    </tr>
    <tr>
        <td>END</td>
        <td>Required</td>
        <td>Required</td>
        <td>Required</td>
        <td>All vCards must end with this property.</td>
        <td>END:VCARD</td>
    </tr>
    <tr>
        <td>FN</td>
        <td>Optional</td>
        <td>Required</td>
        <td>Required</td>
        <td>The formatted name string associated with the vCard object.</td>
        <td>FN:Dr. John Doe</td>
    </tr>
    <tr>
        <td>N</td>
        <td>Required</td>
        <td>Required</td>
        <td>Optional</td>
        <td>A structured representation of the name of the person, place or thing associated with the vCard object. Structure recognizes, in order separated by semicolons: Family Name, Given Name, Additional/Middle Names, Honorific Prefixes, and Honorific Suffixes[3]</td>
        <td>N:Doe;John;;Dr;</td>
    </tr>
    <tr>
        <td>NAME</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Undefined</td>
        <td>Provides a textual representation of the SOURCE property.</td>
        <td></td>
    </tr>
    <tr>
        <td>NICKNAME</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>One or more descriptive/familiar names for the object represented by this vCard.</td>
        <td>NICKNAME:Jon,Johnny</td>
    </tr>
   <tr>
        <td rowspan="6">PHOTO</td>
        <td rowspan="6">Optional</td>
        <td rowspan="6">Optional</td>
        <td rowspan="6">Optional</td>
        <td rowspan="6">An image or photograph of the individual associated with the vCard. It may point to an external URL or may be embedded in the vCard as a Base64 encoded block of text.</td>
        <td>2.1: PHOTO;JPEG:http://example.com/photo.jpg</td>
</tr>
    <tr>
      <td>2.1: PHOTO;JPEG;ENCODING=BASE64:[base64-data]</td>
    </tr>
    <tr><td>3.0: PHOTO;TYPE=JPEG;VALUE=URI:http://example.com/photo.jpg</td>
    </tr>
    <tr><td>3.0: PHOTO;TYPE=JPEG;ENCODING=b:[base64-data]</td>
    </tr>
    <tr><td>4.0: PHOTO;MEDIATYPE=image/jpeg:http://example.com/photo.jpg</td>
    </tr>
    <tr><td>4.0: PHOTO;ENCODING=BASE64;TYPE=JPEG:[base64-data]</td>
    </tr>
    <tr>
        <td>TEL</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>The canonical number string for a telephone number for telephony communication with the vCard object.</td>
        <td>TEL;TYPE=cell:(123) 555-5832</td>
    </tr>
    <tr>
        <td>TITLE</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Specifies the job title, functional position or function of the individual associated with the vCard object within an organization.</td>
        <td>TITLE:V.P. Research and Development</td>
    </tr>
    <tr>
        <td>VERSION</td>
        <td>Required</td>
        <td>Required</td>
        <td>Required</td>
        <td>The version of the vCard specification. In version 4.0, this must come right after the BEGIN property.</td>
        <td>VERSION:3.0</td>
    </tr>
</table>

<h3>Not  implemented yet &#10060; </h3>
<table>
    <tr>
        <td rowspan="2"><b>Name</b></td>
        <td colspan="3"><b>Property presence</b></td>
        <td rowspan="2"><b>Description</b></td>
        <td rowspan="2"><b>Example</b></td>
    </tr>
    <tr>
        <td><b>v. 2.1</b></td>
        <td><b>v. 3.0</b></td>
        <td><b>v. 4.0</b></td>
    </tr>
    <tr>
        <td>AGENT</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Undefined</td>
        <td>Information about another person who will act on behalf of the vCard object. Typically this would be an area administrator, assistant, or secretary for the individual. Can be either a URL or an embedded vCard.</td>
        <td>AGENT:http://mi6.gov.uk/007</td>
    </tr>
    <tr>
        <td>ANNIVERSARY</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Defines the person&#39;s anniversary.</td>
        <td>ANNIVERSARY:19901021</td>
    </tr>
    <tr>
        <td>BDAY</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Date of birth of the individual associated with the vCard.</td>
        <td>BDAY:19700310</td>
    </tr>
      <tr>
        <td>CALADRURI</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>A URL to use for sending a scheduling request to the person&#39;s calendar.</td>
        <td>CALADRURI:http://example.com/calendar/jdoe</td>
    </tr>
    <tr>
        <td>CALURI</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>A URL to the person&#39;s calendar.</td>
        <td>CALURI:http://example.com/calendar/jdoe</td>
    </tr>
    <tr>
        <td>CATEGORIES</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>A list of &quot;tags&quot; that can be used to describe the object represented by this vCard.</td>
        <td>CATEGORIES:swimmer,biker</td>
    </tr>
    <tr>
        <td>CLASS</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Undefined</td>
        <td>Describes the sensitivity of the information in the vCard.</td>
        <td>CLASS:public</td>
    </tr>
    <tr>
        <td>CLIENTPIDMAP</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Used for synchronizing different revisions of the same vCard.</td>
        <td>CLIENTPIDMAP:1;urn:uuid:3df403f4-5924-4bb7-b077-3c711d9eb34b</td>
    </tr>
    <tr>
        <td>FBURL</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Defines a URL that shows when the person is &quot;free&quot; or &quot;busy&quot; on their calendar.</td>
        <td>FBURL:http://example.com/fb/jdoe</td>
    </tr>
    <tr>
        <td>GENDER</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Defines the person&#39;s gender.</td>
        <td>GENDER:F</td>
    </tr>
    <tr>
        <td>GEO</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Specifies a latitude and longitude.</td>
        <td>2.1, 3.0: GEO:39.95;-75.1667 <br>4.0: GEO:geo:39.95,-75.1667</td>
    </tr>
    <tr>
        <td>IMPP</td>
        <td>Undefined</td>
        <td>Maybe</td>
        <td>Optional</td>
        <td>&quot;Defines an instant messenger handle. <br>This property was introduced in a separate RFC when the latest vCard version was 3.0. Therefore, 3.0 vCards might use this property without otherwise declaring it.&quot;</td>
            <td>IMPP:aim:johndoe@aol.com</td>
    </tr>
    <tr>
        <td rowspan="6">KEY</td>
        <td rowspan="6">Optional</td>
        <td rowspan="6">Optional</td>
        <td rowspan="6">Optional</td>
        <td rowspan="6">The public encryption key associated with the vCard object. It may point to an external URL, may be plain text, or may be embedded in the vCard as a Base64 encoded block of text.</td>
        <td>2.1: KEY;PGP:http://example.com/key.pgp</td>
    </tr>
    <tr>
              <td>2.1: KEY;PGP;ENCODING=BASE64:[base64-data]</td>
    </tr>
    <tr>
      <td>3.0: KEY;TYPE=PGP:http://example.com/key.pgp</td>
    </tr>
    <tr><td>3.0: KEY;TYPE=PGP;ENCODING=b:[base64-data]</td>
    </tr>
    <tr><td>4.0: KEY;MEDIATYPE=application/pgp-keys:http://example.com/key.pgp</td>
    </tr>
    <tr><td>4.0: KEY:data:application/pgp-keys;base64,[base64-data]</td>
    </tr>
    <tr>
        <td>KIND</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Defines the type of entity that this vCard represents: &#39;application&#39;, &#39;individual&#39;, &#39;group&#39;, &#39;location&#39; or &#39;organization&#39;; &#39;x-*&#39; values may be used for experimental purposes.[1][2]</td>
        <td>KIND:individual</td>
    </tr>
    <tr>
        <td>LABEL</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Incorporated without</td>
        <td>Represents the actual text that should be put on the mailing label when delivering a physical package to the person/object associated with the vCard (related to the ADR property).</td>
        <td>LABEL;TYPE=HOME:123 Main St.\nSpringfield, IL 12345\nUSA</td>
    </tr>
     <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>Not supported in version 4.0. Instead, this information is stored in the LABEL parameter of the ADR property. Example: ADR;TYPE=home;LABEL=&quot;123 Main St\nNew York, NY 12345&quot;:;;123 Main St;New York;NY;12345;USA</td>
        <td></td>
    </tr>
    <tr>
        <td>LANG</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Defines a language that the person speaks.</td>
        <td>LANG:fr-CA</td>
    </tr>
    <tr>
        <td rowspan="6">LOGO</td>
        <td rowspan="6">Optional</td>
        <td rowspan="6">Optional</td>
        <td rowspan="6">Optional</td>
        <td rowspan="6">An image or graphic of the logo of the organization that is associated with the individual to which the vCard belongs. It may point to an external URL or may be embedded in the vCard as a Base64 encoded block of text.</td>
        <td>2.1: LOGO;PNG:http://example.com/logo.png</td>
    </tr>
    <tr> <td>2.1: LOGO;PNG;ENCODING=BASE64:[base64-data]</td>
    </tr>
    <tr><td>3.0: LOGO;TYPE=PNG:http://example.com/logo.png</td>
    </tr>
    <tr><td>3.0: LOGO;TYPE=PNG;ENCODING=b:[base64-data]</td>
    </tr>
    <tr><td>4.0: LOGO;MEDIATYPE=image/png:http://example.com/logo.png</td>
    </tr>
    <tr><td>4.0: LOGO;ENCODING=BASE64;TYPE=PNG:[base64-data]</td>
    </tr>
    <tr>
        <td>MAILER</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Undefined</td>
        <td>Type of email program used.</td>
        <td>MAILER:Thunderbird</td>
    </tr>
    <tr>
        <td>MEMBER</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Defines a member that is part of the group that this vCard represents. Acceptable values include:</td>
        <td>MEMBER:urn:uuid:03a0e51f-d1aa-4385-8a53-e29025acd8af</td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>a &quot;mailto:&quot; URL containing an email address</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>a UID which references the member&#39;s own vCard</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>The KIND property must be set to &quot;group&quot; in order to use this property.</td>
        <td></td>
    </tr>
    <tr>
        <td>NOTE</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Specifies supplemental information or a comment that is associated with the vCard.</td>
        <td>NOTE:I am proficient in Tiger-Crane Style,\nand I am more than proficient in the exquisite art of the Samurai sword.</td>
    </tr>
    <tr>
        <td>ORG</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>The name and optionally the unit(s) of the organization associated with the vCard object. This property is based on the X.520 Organization Name attribute and the X.520 Organization Unit attribute.</td>
        <td>ORG:Google;GMail Team;Spam Detection Squad</td>
    </tr>
    <tr>
        <td>PRODID</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>The identifier for the product that created the vCard object.</td>
        <td>PRODID:-//ONLINE DIRECTORY//NONSGML Version 1//EN</td>
    </tr>
    <tr>
        <td>PROFILE</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Undefined</td>
        <td>States that the vCard is a vCard.</td>
        <td>PROFILE:VCARD</td>
    </tr>
    <tr>
        <td>RELATED</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Another entity that the person is related to. Acceptable values include:</td>
        <td>RELATED;TYPE=friend:urn:uuid:03a0e51f-d1aa-4385-8a53-e29025acd8af</td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>a &quot;mailto:&quot; URL containing an email address</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>a UID which references the person&#39;s own vCard</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>REV</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>A timestamp for the last time the vCard was updated.</td>
        <td>REV:20121201T134211Z</td>
    </tr>
    <tr>
        <td>ROLE</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>The role, occupation, or business category of the vCard object within an organization.</td>
        <td>ROLE:Executive</td>
    </tr>
    <tr>
        <td>SORT-STRING</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Incorporated without</td>
        <td>Defines a string that should be used when an application sorts this vCard in some way.</td>
        <td>SORT-STRING:Doe</td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>Not supported in version 4.0. Instead, this information is stored in the SORT-AS parameter of the N and/or ORG properties.</td>
        <td></td>
    </tr>
    <tr>
        <td>SOUND</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>By default, if this property is not grouped with other properties it specifies the pronunciation of the FN property of the vCard object. It may point to an external URL or may be embedded in the vCard as a Base64 encoded block of text.</td>
        <td>2.1: SOUND;OGG:http://example.com/sound.ogg</td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>2.1: SOUND;OGG;ENCODING=BASE64:[base64-data]</td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>3.0: SOUND;TYPE=OGG:http://example.com/sound.ogg</td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>3.0: SOUND;TYPE=OGG;ENCODING=b:[base64-data]</td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>4.0: SOUND;MEDIATYPE=audio/ogg:http://example.com/sound.ogg</td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>4.0: SOUND:data:audio/ogg;base64,[base64-data]</td>
    </tr>
    <tr>
        <td>SOURCE</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>A URL that can be used to get the latest version of this vCard.</td>
        <td>SOURCE:http://johndoe.com/vcard.vcf</td>
    </tr>
    <tr>
        <td>TZ</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>The time zone of the vCard object.</td>
        <td>2.1, 3.0: TZ:-0500</td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>4.0: TZ:America/New_York</td>
    </tr>
    <tr>
        <td>UID</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Specifies a value that represents a persistent, globally unique identifier associated with the object.</td>
        <td>UID:urn:uuid:da418720-3754-4631-a169-db89a02b831b</td>
    </tr>
    <tr>
        <td>URL</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>Optional</td>
        <td>A URL pointing to a website that represents the person in some way.</td>
        <td>URL:http://www.johndoe.com</td>
    </tr>
    <tr>
        <td>XML</td>
        <td>Undefined</td>
        <td>Undefined</td>
        <td>Optional</td>
        <td>Any XML data that is attached to the vCard. This is used if the vCard was encoded in XML (xCard standard) and the XML document contained elements which are not part of the xCard standard.</td>
        <td>XML:&lt;b&gt;Not an xCard XML element&lt;/b&gt;</td>
    </tr>
</table>

