using System.Xml;

var xmlString = @$" <post-method xmlns:S=""X"">
                        <response-code>200</response-code>
                        <response-desc>OK</response-desc>
                        <entity>
                            <content-type>text/xml</content-type>
                            <content>
                                <S:Body>
                                    <S:execSyncResponse>
                                        <S:return>
                                            <S:errorType>U</S:errorType>
                                            <S:serviceStatus>1</S:serviceStatus>
                                            <S:serviceDescription/>
                                            <S:serviceException>OK</S:serviceException>
                                        </S:return>
                                    </S:execSyncResponse>
                                </S:Body>
                            </content>
                        </entity>
                    </post-method>";

var xmlDocument = new XmlDocument();
xmlDocument.LoadXml(xmlString);

var xmlNodeList = xmlDocument.GetElementsByTagName("S:return");

foreach (XmlNode node in xmlNodeList)
{
    var result = @$"Error type: { node["S:errorType"].InnerText }
Service status: { node["S:serviceStatus"].InnerText }
Service description: { node["S:serviceDescription"].InnerText }
Service exception: { node["S:serviceException"].InnerText }";

    Console.WriteLine(result);
}