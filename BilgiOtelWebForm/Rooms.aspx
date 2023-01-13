<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Rooms.aspx.cs" Inherits="BilgiOtelWebForm.Rooms" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Breadcrumb Section Begin -->
    <div class="breadcrumb-section">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb-text">
                        <h2>Our Rooms</h2>
                        <div class="bt-option">
                            <a href="Home.aspx">Home</a>
                            <span>Rooms</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb Section End -->
    <form action="/" method="post" runat="server">
    <div>
        
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <asp:Button ID="Button1" runat="server" Text="Button" />

    </div>
        
    <!-- Rooms Section Begin -->
    <section class="rooms-section spad">
        <div class="container">
            <div class="row">
                
                <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                    <ItemTemplate>
                        <div class="col-lg-4 col-md-6">
                            <div class="room-item">
                                <img src="img/room/room-1.jpg" alt="">
                                <div class="ri-text">
                                    <h4>ODA Numarası: <%#Eval("OdaId")%></h4>
                                    <h3><%#Eval("OdaFiyat")%>$<span>/Pernight</span></h3>
                                    <table>
                                        <tbody>
                                            <tr>
                                                <td class="r-o">Size:</td>
                                                <td><%#Eval("OdaEbatBoyut")%></td>
                                            </tr>
                                            <tr>
                                                <td class="r-o">Capacity:</td>
                                                <td><%#Eval("OdaKisiSayisi")%></td>
                                            </tr>
                                            <tr>
                                                <td class="r-o">Bed:</td>
                                                <td><%#Eval("OdaYatakTipi")%></td>
                                            </tr>
                                            <tr>
                                                <td class="r-o">Services:</td>
                                                
                                                <td>
                                                   Wifi <asp:CheckBox ID="CheckBox1" runat="server" Checked=' <%#Eval("OdaWifiOk")%>' /> 
                                                    <br /> Television <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%#Eval("OdaTvOk")%>' ></asp:CheckBox>
                                                    <br />  MiniBar   <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%#Eval("OdaMiniBarOk")%> ' ></asp:CheckBox>
                                                    <br />  Klima     <asp:CheckBox ID="CheckBox4" runat="server" Checked='<%#Eval("OdaKlimaOk")%>'></asp:CheckBox> 
                                                    <br />  Kurutma   <asp:CheckBox ID="CheckBox5" runat="server" Checked='<%#Eval("OdaKurutmaOk")%>'></asp:CheckBox>
                                                    <br />  Kasa      <asp:CheckBox ID="CheckBox6" runat="server" Checked='<%#Eval("[OdaKasaOk]")%>'></asp:CheckBox>
                                                    <br />  Balkon    <asp:CheckBox ID="CheckBox7" runat="server" Checked='<%#Eval("[OdaBalkonOk]")%>'></asp:CheckBox>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <a href="#" class="primary-btn">More Details</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                 </form>  
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_Bilgi_HotelConnectionString %>" SelectCommand="sp_WebSorgu2" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="Tarih1" Name="ilktarih" Type="DateTime"></asp:QueryStringParameter>
            <asp:QueryStringParameter QueryStringField="Tarih2" Name="ikincitarih" Type="DateTime"></asp:QueryStringParameter>
        </SelectParameters>
    </asp:SqlDataSource>
            </div>
            <%--  <div class="col-lg-4 col-md-6">
                    <div class="room-item">
                        <img src="img/room/room-2.jpg" alt="">
                        <div class="ri-text">
                            <h4>Deluxe Room</h4>
                            <h3>159$<span>/Pernight</span></h3>
                            <table>
                                <tbody>
                                    <tr>
                                        <td class="r-o">Size:</td>
                                        <td>30 ft</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Capacity:</td>
                                        <td>Max persion 5</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Bed:</td>
                                        <td>King Beds</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Services:</td>
                                        <td>Wifi, Television, Bathroom,...</td>
                                    </tr>
                                </tbody>
                            </table>
                            <a href="#" class="primary-btn">More Details</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6">
                    <div class="room-item">
                        <img src="img/room/room-3.jpg" alt="">
                        <div class="ri-text">
                            <h4>Double Room</h4>
                            <h3>159$<span>/Pernight</span></h3>
                            <table>
                                <tbody>
                                    <tr>
                                        <td class="r-o">Size:</td>
                                        <td>30 ft</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Capacity:</td>
                                        <td>Max persion 2</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Bed:</td>
                                        <td>King Beds</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Services:</td>
                                        <td>Wifi, Television, Bathroom,...</td>
                                    </tr>
                                </tbody>
                            </table>
                            <a href="#" class="primary-btn">More Details</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6">
                    <div class="room-item">
                        <img src="img/room/room-4.jpg" alt="">
                        <div class="ri-text">
                            <h4>Luxury Room</h4>
                            <h3>159$<span>/Pernight</span></h3>
                            <table>
                                <tbody>
                                    <tr>
                                        <td class="r-o">Size:</td>
                                        <td>30 ft</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Capacity:</td>
                                        <td>Max persion 1</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Bed:</td>
                                        <td>King Beds</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Services:</td>
                                        <td>Wifi, Television, Bathroom,...</td>
                                    </tr>
                                </tbody>
                            </table>
                            <a href="#" class="primary-btn">More Details</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6">
                    <div class="room-item">
                        <img src="img/room/room-5.jpg" alt="">
                        <div class="ri-text">
                            <h4>Room With View</h4>
                            <h3>159$<span>/Pernight</span></h3>
                            <table>
                                <tbody>
                                    <tr>
                                        <td class="r-o">Size:</td>
                                        <td>30 ft</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Capacity:</td>
                                        <td>Max persion 1</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Bed:</td>
                                        <td>King Beds</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Services:</td>
                                        <td>Wifi, Television, Bathroom,...</td>
                                    </tr>
                                </tbody>
                            </table>
                            <a href="#" class="primary-btn">More Details</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6">
                    <div class="room-item">
                        <img src="img/room/room-6.jpg" alt="">
                        <div class="ri-text">
                            <h4>Small View</h4>
                            <h3>159$<span>/Pernight</span></h3>
                            <table>
                                <tbody>
                                    <tr>
                                        <td class="r-o">Size:</td>
                                        <td>30 ft</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Capacity:</td>
                                        <td>Max persion 2</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Bed:</td>
                                        <td>King Beds</td>
                                    </tr>
                                    <tr>
                                        <td class="r-o">Services:</td>
                                        <td>Wifi, Television, Bathroom,...</td>
                                    </tr>
                                </tbody>
                            </table>
                            <a href="#" class="primary-btn">More Details</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="room-pagination">
                        <a href="#">1</a>
                        <a href="#">2</a>
                        <a href="#">Next <i class="fa fa-long-arrow-right"></i></a>
                    </div>
                </div>--%>
        </div>
        </div>
    </section>
    <!-- Rooms Section End -->
</asp:Content>
