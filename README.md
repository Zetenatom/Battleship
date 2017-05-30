<Window x:Class="Battleship.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Battleship"
        mc:Ignorable="d"
        Title="MainWindow" Height="350" Width="525">
    <Grid Background="Blue" ShowGridLines="True">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Name="Boarder" Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
            <ColumnDefinition Width="48*" />
        </Grid.ColumnDefinitions>
        
        <Grid.RowDefinitions>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            <RowDefinition Height="1*"/>
            
        </Grid.RowDefinitions>
        <Button Name="Alpha1" Grid.Column="1">Alpha</Button>
        <Button Name="Beta1" Grid.Column="2">Beta</Button>
        <Button Name="Charlie1" Grid.Column="3">Charlie</Button>
        <Button Name="Delta1" Grid.Column="4">Delta</Button>
        <Button Name="Echo1" Grid.Column="5">Echo</Button>
        <Button Name="Foxtrot1" Grid.Column="6">Foxtrot</Button>
        <Button Name="Gamma1" Grid.Column="7">Gamma</Button>
        <Button Name="Hotel1" Grid.Column="8">Hotel</Button>
        <Button Name="Indego1" Grid.Column="9">Indego</Button>
        <Button Name="Juliet1" Grid.Column="10">Juliet</Button>
        <Button Name="Q1" Grid.Row="1">1</Button>
        <Button Name="Q2" Grid.Row="2">2</Button>
        <Button Name="Q3" Grid.Row="3">3</Button>
        <Button Name="Q4" Grid.Row="4">4</Button>
        <Button Name="Q5" Grid.Row="5">5</Button>
        <Button Name="Q6" Grid.Row="6">6</Button>
        <Button Name="Q7" Grid.Row="7">7</Button>
        <Button Name="Q8" Grid.Row="8">8</Button>
        <Button Name="Q9" Grid.Row="9">9</Button>
        <Button Name="Q10" Grid.Row="10">10</Button>

        <TextBlock Grid.Column="0" Grid.Row="0" Background="White" Text="Player 1" TextAlignment="Center"></TextBlock>
        <TextBlock Grid.Column="11" Grid.Row="0" Background="White" Text="Player 2" TextAlignment="Center"></TextBlock>
        
        <Button Name="Alpha" Click="Button_ClickAlpha" Grid.Column="12">Alpha</Button>
        <Button Name="Beta" Click="Button_ClickBeta" Grid.Column="13">Beta</Button>
        <Button Name="Charlie" Click="Button_ClickCharlie" Grid.Column="14">Charlie</Button>
        <Button Name="Delta" Click="Button_ClickDelta" Grid.Column="15">Delta</Button>
        <Button Name="Echo" Click="Button_ClickEcho" Grid.Column="16">Echo</Button>
        <Button Name="Foxtrot" Click="Button_ClickFoxtrot" Grid.Column="17">Foxtrot</Button>
        <Button Name="Gamma" Click="Button_ClickGamma" Grid.Column="18">Gamma</Button>
        <Button Name="Hotel" Click="Button_ClickHotel" Grid.Column="19">Hotel</Button>
        <Button Name="Indego" Click="Button_ClickIndego" Grid.Column="20">Indego</Button>
        <Button Name="Juliet" Click="Button_ClickJuliet" Grid.Column="21">Juliet</Button>
        <Button Name="button1" Click="Button_Click1" Grid.Column="11" Grid.Row="1">1</Button>
        <Button Name="button2" Click="Button_Click2" Grid.Column="11" Grid.Row="2">2</Button>
        <Button Name="button3" Click="Button_Click3" Grid.Column="11" Grid.Row="3">3</Button>
        <Button Name="button4" Click="Button_Click4" Grid.Column="11" Grid.Row="4">4</Button>
        <Button Name="button5" Click="Button_Click5" Grid.Column="11" Grid.Row="5">5</Button>
        <Button Name="button6" Click="Button_Click6" Grid.Column="11" Grid.Row="6">6</Button>
        <Button Name="button7" Click="Button_Click7" Grid.Column="11" Grid.Row="7">7</Button>
        <Button Name="button8" Click="Button_Click8" Grid.Column="11" Grid.Row="8">8</Button>
        <Button Name="button9" Click="Button_Click9" Grid.Column="11" Grid.Row="9">9</Button>
        <Button Name="button10" Click="Button_Click10" Grid.Column="11" Grid.Row="10">10</Button>

        <Label MouseDown="Labels_MouseDown" Name="P1A1" Grid.Column="1" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1A2" Grid.Column="1" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1A3" Grid.Column="1" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1A4" Grid.Column="1" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1A5" Grid.Column="1" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1A6" Grid.Column="1" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1A7" Grid.Column="1" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1A8" Grid.Column="1" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1A9" Grid.Column="1" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1A10" Grid.Column="1" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B1" Grid.Column="2" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B2" Grid.Column="2" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B3" Grid.Column="2" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B4" Grid.Column="2" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B5" Grid.Column="2" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B6" Grid.Column="2" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B7" Grid.Column="2" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B8" Grid.Column="2" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B9" Grid.Column="2" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1B10" Grid.Column="2" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C1" Grid.Column="3" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C2" Grid.Column="3" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C3" Grid.Column="3" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C4" Grid.Column="3" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C5" Grid.Column="3" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C6" Grid.Column="3" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C7" Grid.Column="3" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C8" Grid.Column="3" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C9" Grid.Column="3" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1C10" Grid.Column="3" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D1" Grid.Column="4" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D2" Grid.Column="4" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D3" Grid.Column="4" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D4" Grid.Column="4" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D5" Grid.Column="4" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D6" Grid.Column="4" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D7" Grid.Column="4" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D8" Grid.Column="4" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D9" Grid.Column="4" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1D10" Grid.Column="4" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E1" Grid.Column="5" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E2" Grid.Column="5" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E3" Grid.Column="5" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E4" Grid.Column="5" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E5" Grid.Column="5" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E6" Grid.Column="5" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E7" Grid.Column="5" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E8" Grid.Column="5" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E9" Grid.Column="5" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1E10" Grid.Column="5" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F1" Grid.Column="6" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F2" Grid.Column="6" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F3" Grid.Column="6" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F4" Grid.Column="6" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F5" Grid.Column="6" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F6" Grid.Column="6" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F7" Grid.Column="6" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F8" Grid.Column="6" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F9" Grid.Column="6" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1F10" Grid.Column="6" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G1" Grid.Column="7" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G2" Grid.Column="7" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G3" Grid.Column="7" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G4" Grid.Column="7" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G5" Grid.Column="7" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G6" Grid.Column="7" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G7" Grid.Column="7" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G8" Grid.Column="7" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G9" Grid.Column="7" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1G10" Grid.Column="7" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H1" Grid.Column="8" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H2" Grid.Column="8" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H3" Grid.Column="8" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H4" Grid.Column="8" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H5" Grid.Column="8" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H6" Grid.Column="8" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H7" Grid.Column="8" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H8" Grid.Column="8" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H9" Grid.Column="8" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1H10" Grid.Column="8" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I1" Grid.Column="9" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I2" Grid.Column="9" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I3" Grid.Column="9" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I4" Grid.Column="9" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I5" Grid.Column="9" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I6" Grid.Column="9" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I7" Grid.Column="9" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I8" Grid.Column="9" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I9" Grid.Column="9" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1I10" Grid.Column="9" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J1" Grid.Column="10" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J2" Grid.Column="10" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J3" Grid.Column="10" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J4" Grid.Column="10" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J5" Grid.Column="10" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J6" Grid.Column="10" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J7" Grid.Column="10" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J8" Grid.Column="10" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J9" Grid.Column="10" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P1J10" Grid.Column="10" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A1" Grid.Column="12" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A2" Grid.Column="12" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A3" Grid.Column="12" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A4" Grid.Column="12" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A5" Grid.Column="12" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A6" Grid.Column="12" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A7" Grid.Column="12" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A8" Grid.Column="12" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A9" Grid.Column="12" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2A10" Grid.Column="12" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B1" Grid.Column="13" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B2" Grid.Column="13" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B3" Grid.Column="13" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B4" Grid.Column="13" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B5" Grid.Column="13" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B6" Grid.Column="13" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B7" Grid.Column="13" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B8" Grid.Column="13" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B9" Grid.Column="13" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2B10" Grid.Column="13" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C1" Grid.Column="14" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C2" Grid.Column="14" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C3" Grid.Column="14" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C4" Grid.Column="14" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C5" Grid.Column="14" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C6" Grid.Column="14" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C7" Grid.Column="14" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C8" Grid.Column="14" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C9" Grid.Column="14" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2C10" Grid.Column="14" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D1" Grid.Column="15" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D2" Grid.Column="15" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D3" Grid.Column="15" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D4" Grid.Column="15" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D5" Grid.Column="15" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D6" Grid.Column="15" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D7" Grid.Column="15" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D8" Grid.Column="15" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D9" Grid.Column="15" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2D10" Grid.Column="15" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E1" Grid.Column="16" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E2" Grid.Column="16" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E3" Grid.Column="16" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E4" Grid.Column="16" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E5" Grid.Column="16" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E6" Grid.Column="16" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E7" Grid.Column="16" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E8" Grid.Column="16" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E9" Grid.Column="16" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2E10" Grid.Column="16" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F1" Grid.Column="17" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F2" Grid.Column="17" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F3" Grid.Column="17" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F4" Grid.Column="17" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F5" Grid.Column="17" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F6" Grid.Column="17" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F7" Grid.Column="17" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F8" Grid.Column="17" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F9" Grid.Column="17" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2F10" Grid.Column="17" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G1" Grid.Column="18" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G2" Grid.Column="18" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G3" Grid.Column="18" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G4" Grid.Column="18" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G5" Grid.Column="18" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G6" Grid.Column="18" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G7" Grid.Column="18" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G8" Grid.Column="18" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G9" Grid.Column="18" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2G10" Grid.Column="18" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H1" Grid.Column="19" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H2" Grid.Column="19" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H3" Grid.Column="19" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H4" Grid.Column="19" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H5" Grid.Column="19" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H6" Grid.Column="19" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H7" Grid.Column="19" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H8" Grid.Column="19" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H9" Grid.Column="19" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2H10" Grid.Column="19" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I1" Grid.Column="20" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I2" Grid.Column="20" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I3" Grid.Column="20" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I4" Grid.Column="20" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I5" Grid.Column="20" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I6" Grid.Column="20" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I7" Grid.Column="20" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I8" Grid.Column="20" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I9" Grid.Column="20" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2I10" Grid.Column="20" Grid.Row="10"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J1" Grid.Column="21" Grid.Row="1"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J2" Grid.Column="21" Grid.Row="2"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J3" Grid.Column="21" Grid.Row="3"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J4" Grid.Column="21" Grid.Row="4"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J5" Grid.Column="21" Grid.Row="5"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J6" Grid.Column="21" Grid.Row="6"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J7" Grid.Column="21" Grid.Row="7"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J8" Grid.Column="21" Grid.Row="8"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J9" Grid.Column="21" Grid.Row="9"></Label>
        <Label MouseDown="Labels_MouseDown" Name="P2J10" Grid.Column="21" Grid.Row="10"></Label>
    </Grid>
</Window>

