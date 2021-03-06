﻿Public Class AppModule
    'Get Application Modul List
    Public Function GetAppModule() As DataTable
        Dim oDS As New DataSet
        Dim oDT As DataTable
        Dim oApp As DataRow

        'Create DataTable & Define Column
        oDT = oDS.Tables.Add("AppModule")
        oDT.Columns.Add("AppID")
        oDT.Columns.Add("AppDescription")

        '*************************************************************************
        'Extruder
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R100120"
        oApp(1) = "Extruder | Lap. Pemakaian Bahan Extruder"

        oApp = oDT.Rows.Add()
        oApp(0) = "R100100"
        oApp(1) = "Extruder | R100100 - Lap. Stock Bahan Floor"

        oApp = oDT.Rows.Add()
        oApp(0) = "R100110"
        oApp(1) = "Extruder | R100110 - Lap. Inventory Transfer"

        oApp = oDT.Rows.Add()
        oApp(0) = "RDP1100"
        oApp(1) = "Extruder | RDP1100 - Lap. Rekap Produksi | Extruder"

        oApp = oDT.Rows.Add()
        oApp(0) = "RDP1200"
        oApp(1) = "Extruder | RDP1200 - Lap. Downtime Produksi | Extruder"

        oApp = oDT.Rows.Add()
        oApp(0) = "RDP1400"
        oApp(1) = "Extruder | RDP1400 - Lap. Personnel Produksi | Extruder"

        oApp = oDT.Rows.Add()
        oApp(0) = "R100140"
        oApp(1) = "Extruder | Analisa Extruder"

        oApp = oDT.Rows.Add()
        oApp(0) = "EXT001"
        oApp(1) = "Extruder | Grafik Afval Extruder"

        oApp = oDT.Rows.Add()
        oApp(0) = "EXT002"
        oApp(1) = "Extruder | Lap. Hasil Extruder By Status SQ"


        '*************************************************************************
        'Benang Multifilamen
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R500110"
        oApp(1) = "BMF | R500110 - Lap. Pemakaian Bahan Benang Multifilament"

        oApp = oDT.Rows.Add()
        oApp(0) = "R500100"
        oApp(1) = "BMF | R500100 - Lap. Produksi Benang Multifilament"

        oApp = oDT.Rows.Add()
        oApp(0) = "R500160"
        oApp(1) = "BMF | R500160 - Lap. Rekap Hasil Benang Multifilament"

        oApp = oDT.Rows.Add()
        oApp(0) = "BMF001"
        oApp(1) = "BMF | Laporan Grafik Afval BMF"

        oApp = oDT.Rows.Add()
        oApp(0) = "BMF002"
        oApp(1) = "BMF | Laporan Stock Floor BMF"



        '*************************************************************************
        'Cloom
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R200130"
        oApp(1) = "CL | R200130 - Lap. Analisa Produksi Loom"

        oApp = oDT.Rows.Add()
        oApp(0) = "R200140"
        oApp(1) = "CL | R200140 - Lap. Analisa Produksi Loom By Mesin"

        oApp = oDT.Rows.Add()
        oApp(0) = "R200180"
        oApp(1) = "CL | R200180 - Lap. Pemakaian Bahan Loom"

        oApp = oDT.Rows.Add()
        oApp(0) = "R200150"
        oApp(1) = "CL | R200150 - Lap. Penyelesaian WO Loom"

        oApp = oDT.Rows.Add()
        oApp(0) = "R200160"
        oApp(1) = "CL | R200160 - Lap. Penyelesaian WO Loom Summary"

        oApp = oDT.Rows.Add()
        oApp(0) = "R200160B"
        oApp(1) = "CL | R200160b - Lap. Penyelesaian WO Loom Summary - B"

        oApp = oDT.Rows.Add()
        oApp(0) = "R200170"
        oApp(1) = "CL | R200170 - Lap. Analisa Berat Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "RDP2200"
        oApp(1) = "CL Daily Ops | RDP2200 - Lap. Operasional | Circular Loom"

        oApp = oDT.Rows.Add()
        oApp(0) = "RDP2100"
        oApp(1) = "CL Daily Ops | RDP2100 - Lap. Hasil Produksi | Circular Loom"

        '*************************************************************************
        'Finishing 1
        '*************************************************************************

        oApp = oDT.Rows.Add()
        oApp(0) = "R320100"
        oApp(1) = "printing | R320100 - Lap. Hasil Printing Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "R320120"
        oApp(1) = "printing | R320120 - Lap. Pemakaian Bahan Pembantu Printing Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "R320110"
        oApp(1) = "printing | R320110 - Lap. Stock Roll Printing"

        oApp = oDT.Rows.Add()
        oApp(0) = "R320150"
        oApp(1) = "printing | R320150 - Lap. Penyelesaian WO Printing Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "R321100"
        oApp(1) = "cutting | R321100 - Lap. Hasil Cutting Karung"

        oApp = oDT.Rows.Add()
        oApp(0) = "R321110"
        oApp(1) = "cutting | R321110 - Lap. Stock Hasil Cutting Karung"

        oApp = oDT.Rows.Add()
        oApp(0) = "R321150"
        oApp(1) = "cutting | R321150 - Lap. Penyelesaian WO Cutting"

        oApp = oDT.Rows.Add()
        oApp(0) = "R322100"
        oApp(1) = "jahit | R322100 - Lap. Hasil Jahit Karung"

        oApp = oDT.Rows.Add()
        oApp(0) = "R322110"
        oApp(1) = "jahit | R322110 - Lap. Stock Hasil Jahit Karung"

        oApp = oDT.Rows.Add()
        oApp(0) = "R322150"
        oApp(1) = "jahit | R322150 - Lap. Penyelesaian WO Jahit"

        oApp = oDT.Rows.Add()
        oApp(0) = "R323100"
        oApp(1) = "printing pcs | R323100 - Lap. Hasil Printing Pcs"

        oApp = oDT.Rows.Add()
        oApp(0) = "R323110"
        oApp(1) = "printing pcs | R323110 - Lap. Stock Hasil Printing Pcs"

        oApp = oDT.Rows.Add()
        oApp(0) = "R324100"
        oApp(1) = "inner | R324100 - Lap. Hasil Inner"

        oApp = oDT.Rows.Add()
        oApp(0) = "R324110"
        oApp(1) = "inner | R324110 - Lap. Stock Hasil Inner"

        oApp = oDT.Rows.Add()
        oApp(0) = "R329100"
        oApp(1) = "ballpress | R329100 - Lap. Hasil Ballpress Karung"

        oApp = oDT.Rows.Add()
        oApp(0) = "R329110"
        oApp(1) = "ballpress | R329110 - Lap. Stock Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "R329150"
        oApp(1) = "ballpress | R329150 - Lap. Penyelesaian WO Packing Karung"

        oApp = oDT.Rows.Add()
        oApp(0) = "R329120"
        oApp(1) = "lain lain | R329120 - Daftar Item Produksi"

        oApp = oDT.Rows.Add()
        oApp(0) = "R210130"
        oApp(1) = "lain lain | R210130 - Lap. Perutukan Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "INN001"
        oApp(1) = "Inner | Lap. Pemakaian Bahan Inner"

        '*************************************************************************
        'Gudang Benang
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R110130"
        oApp(1) = "Gudang Benang | R110130 - Lap. Penerimaan Gudang Benang"

        oApp = oDT.Rows.Add()
        oApp(0) = "R110100"
        oApp(1) = "Gudang Benang | R110100 - Lap. Penerimaan Benang"

        oApp = oDT.Rows.Add()
        oApp(0) = "R110110"
        oApp(1) = "Gudang Benang | R110110 - Lap. Pengeluaran Benang"

        oApp = oDT.Rows.Add()
        oApp(0) = "R110120"
        oApp(1) = "Gudang Benang | R110120 - Lap. Stock Benang"

        oApp = oDT.Rows.Add()
        oApp(0) = "R110140"
        oApp(1) = "Gudang Benang | R110140 - Lap. Stock Gudang Benang Per Area"

        oApp = oDT.Rows.Add()
        oApp(0) = "R110190"
        oApp(1) = "Gudang Benang | R110190 - Lap. Penerimaan Benang (Summary By Mesin)"

        oApp = oDT.Rows.Add()
        oApp(0) = "R110200"
        oApp(1) = "Gudang Benang | R110200 - Lap. Penerimaan Benang (Summary)"

        oApp = oDT.Rows.Add()
        oApp(0) = "R110220"
        oApp(1) = "Gudang Benang | R110220 - Lap. Pengeluaran Benang"

        oApp = oDT.Rows.Add()
        oApp(0) = "R110230"
        oApp(1) = "Gudang Benang | R110230 - Lap. Detail Pengeluaran Benang"

        oApp = oDT.Rows.Add()
        oApp(0) = "R110240"
        oApp(1) = "Gudang Benang | Lap. Retur Benang"

        oApp = oDT.Rows.Add()
        oApp(0) = "GBN0001"
        oApp(1) = "Gudang Benang | Lap. Transform Benang"

        oApp = oDT.Rows.Add()
        oApp(0) = "GBN0002"
        oApp(1) = "Gudang Benang | Lap. Kartu Stock (Support PPIC)"

        '*************************************************************************
        'Gudang Roll
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R210100"
        oApp(1) = "Gudang Roll | R210100 - Lap. Penerimaan Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "R210110"
        oApp(1) = "Gudang Roll | R210110 - Lap. Stock Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "R210120"
        oApp(1) = "Gudang Roll | R210120 - Lap. Mutasi Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "R210190"
        oApp(1) = "Gudang Roll | R210190 - Lap. Penerimaan Roll Makloon"

        '*************************************************************************
        'GUDANG AFVAL/ RECYCLE
        '*************************************************************************

        oApp = oDT.Rows.Add()
        oApp(0) = "R600110"
        oApp(1) = "GUDANG AFVAL/ RECYCLE | Lap. Penerimaan Afval Produksi"

        oApp = oDT.Rows.Add()
        oApp(0) = "R610100"
        oApp(1) = "GUDANG AFVAL/ RECYCLE | Lap. Hasil Recycle"

        oApp = oDT.Rows.Add()
        oApp(0) = "R600100"
        oApp(1) = "GUDANG AFVAL/ RECYCLE | Lap. Afval Produksi"

        oApp = oDT.Rows.Add()
        oApp(0) = "AFV001"
        oApp(1) = "GUDANG AFVAL/ RECYCLE | Lap. Grafik Recycle"

        oDS.AcceptChanges()
        GetAppModule = oDT


        '*************************************************************************
        'FINISHING 2
        '*************************************************************************

        oApp = oDT.Rows.Add()
        oApp(0) = "R311110"
        oApp(1) = "FINISHING 2 | Lap. Stock Roll Slitting"

        oApp = oDT.Rows.Add()
        oApp(0) = "R310110"
        oApp(1) = "FINISHING 2 | Lap. Stock Roll Laminasi"

        oApp = oDT.Rows.Add()
        oApp(0) = "R311120"
        oApp(1) = "FINISHING 2 | Lap. Slitting - Analisa Roll Ke Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "R311150"
        oApp(1) = "FINISHING 2 | Lap. Penyelesaian WO Slitting"

        oApp = oDT.Rows.Add()
        oApp(0) = "R319150"
        oApp(1) = "FINISHING 2 | Lap. Penyelesaian WO Packing Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R310150"
        oApp(1) = "FINISHING 2 | Lap. Penyelesaian WO Laminasi"

        oApp = oDT.Rows.Add()
        oApp(0) = "R312150"
        oApp(1) = "FINISHING 2 | Lap. Penyelesaian WO Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R312120"
        oApp(1) = "FINISHING 2 | Lap. Pemakaian Bahan Roll Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R310120"
        oApp(1) = "FINISHING 2 | Lap. Pemakaian Bahan Pembantu Laminasi"

        oApp = oDT.Rows.Add()
        oApp(0) = "R311100"
        oApp(1) = "FINISHING 2 | Lap. Hasil Slitting"

        oApp = oDT.Rows.Add()
        oApp(0) = "R312130"
        oApp(1) = "FINISHING 2 | Lap. Hasil Produksi Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R310100"
        oApp(1) = "FINISHING 2 | Lap. Hasil Laminasi"

        oApp = oDT.Rows.Add()
        oApp(0) = "R319110"
        oApp(1) = "BALLPRESS CEMENT BAG | Lap. Stock Ballpress Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R319100"
        oApp(1) = "BALLPRESS CEMENT BAG | Lap. Hasil Ballpress Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R312110"
        oApp(1) = "BALLPRESS KARUNG | Lap. Stock Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R400100"
        oApp(1) = "BALLPRESS KARUNG | Lap. Penyerahan Hasil Produksi"

        oApp = oDT.Rows.Add()
        oApp(0) = "R312100"
        oApp(1) = "BALLPRESS KARUNG | Lap. Hasil Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R310131"
        oApp(1) = "Laminasi | Lap. Analisa Roll to Roll Laminasi"

        '*************************************************************************
        'PPIC
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "IC10001"
        oApp(1) = "PPIC | Lap. Plan Mesin Per tanggal"

        oApp = oDT.Rows.Add()
        oApp(0) = "IC10002"
        oApp(1) = "PPIC | Lap. Monitoring WO List"

        oApp = oDT.Rows.Add()
        oApp(0) = "IC10003"
        oApp(1) = "PPIC | Lap. Backorder Produksi PPIC"

        oApp = oDT.Rows.Add()
        oApp(0) = "IC10004"
        oApp(1) = "PPIC | Lap. Monitoring Order Produksi"

        oApp = oDT.Rows.Add()
        oApp(0) = "IC10005"
        oApp(1) = "PPIC | Lap. Sinkronisasi Karung"

        '*************************************************************************
        'Cost Accounting
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "CACC001"
        oApp(1) = "CostACC | Lap. List BOM WO"

        oApp = oDT.Rows.Add()
        oApp(0) = "CACC002"
        oApp(1) = "CostACC | Lap. Variance"

        oApp = oDT.Rows.Add()
        oApp(0) = "CACC003"
        oApp(1) = "CostACC | Lap. WIP"

        oApp = oDT.Rows.Add()
        oApp(0) = "CACC004"
        oApp(1) = "CostACC | Lap. Analisa WorkOrder Cost Acc"

        oApp = oDT.Rows.Add()
        oApp(0) = "CACC005"
        oApp(1) = "CostACC | Lap. Analisa WorkOrder Cost Acc Periodic"

        oApp = oDT.Rows.Add()
        oApp(0) = "CACC006"
        oApp(1) = "CostACC | Lap. Perhitungan Harga Pokok Produksi"

        oApp = oDT.Rows.Add()
        oApp(0) = "CACC007"
        oApp(1) = "CostACC | Lap. Stock Opname"

        oApp = oDT.Rows.Add()
        oApp(0) = "CACC008"
        oApp(1) = "CostACC | Lap. Perbandingan SAP vs Console"

        oApp = oDT.Rows.Add()
        oApp(0) = "CACC009"
        oApp(1) = "CostACC | Lap. Master BOM"

        '*************************************************************************
        'Analisa
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "AN001"
        oApp(1) = "Analisa | Lap. Analisa Roll to Roll Printing"

        oApp = oDT.Rows.Add()
        oApp(0) = "AN002"
        oApp(1) = "Analisa | Lap. Analisa Roll to Pcs Cutting"

        oApp = oDT.Rows.Add()
        oApp(0) = "AN003"
        oApp(1) = "Analisa | Lap. Analisa Afval Vs BS"

        '*************************************************************************
        'Gudang Induk
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "GI001"
        oApp(1) = "Gud. Induk | Lap. Retur Hasil Produksi"

        oApp = oDT.Rows.Add()
        oApp(0) = "GI002"
        oApp(1) = "Gud. Induk | Lap. Peforma Penyerahan Hasil Produksi"

        oApp = oDT.Rows.Add()
        oApp(0) = "GI003"
        oApp(1) = "Gud. Induk | Lap. Stock BMF"

        '*************************************************************************
        'Cemment Bag
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "CB001"
        oApp(1) = "Cemment Bag | Lap. Analisa Roll to Pcs Cemment Bag"

        '*************************************************************************
        'BallPress
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "BL001"
        oApp(1) = "BallPress | Lap. Transform Ball to Pcs"

        oApp = oDT.Rows.Add()
        oApp(0) = "BL002"
        oApp(1) = "BallPress | Lap. Serah Terima Ballpress"


    End Function

    'Application Modul 
    Public Function Form(ByVal AppID As String, ByVal Session As Object) As Object
        Dim AppForm As Object = Nothing

        ActiveSession.KodePerusahaan = Session.KodePerusahaan
        ActiveSession.NamaPerusahaan = Session.NamaPerusahaan
        ActiveSession.Alamat1 = Session.Alamat1
        ActiveSession.Alamat2 = Session.Alamat2
        ActiveSession.Kota = Session.Kota
        ActiveSession.Propinsi = Session.Propinsi
        ActiveSession.NoTelpon = Session.NoTelpon
        ActiveSession.NoFax = Session.NoFax
        ActiveSession.KodeUser = Session.KodeUser
        ActiveSession.NamaUser = Session.NamaUser
        ActiveSession.HakAkses = Session.HakAkses
        ActiveSession.Supervisor = Session.Supervisor
        ActiveSession.HakUbahTanggal = Session.HakUbahTanggal
        ActiveSession.DBConnection = Session.DBConnection

        '*************************************************************************
        'Master Data
        '*************************************************************************

        Select Case AppID
            Case "R100120"
                AppForm = New frmRPT100_120_PemakaianBahanExtruder
            Case "R100100"
                AppForm = New frmRPTPro_SaldoStockBahan
            Case "R100110"
                AppForm = New frmRPT100_110_InventoryTransferExtruder
            Case "RDP1100"
                AppForm = New frmRPTRekap_ProExtruder
            Case "RDP1200"
                AppForm = New frmRPTDowntime_ProExtruder
            Case "R110130"
                AppForm = New frmRPT110_130_GudangBenang
            Case "R110100"
                AppForm = New frmRPT110_100_GudangBenang
            Case "R110110"
                AppForm = New frmRPT110_110_GudangBenang
            Case "R110120"
                AppForm = New frmRPT110_120_GudangBenang
            Case "R110140"
                AppForm = New frmRPT110_140_GudangBenang
            Case "R110190"
                AppForm = New frmRPT110_190_GudangBenang
            Case "R110200"
                AppForm = New frmRPT110_200_GudangBenang
            Case "R110220"
                AppForm = New frmRPT110_220_GudangBenang
            Case "R110230"
                AppForm = New frmRPT110_230_GudangBenang
            Case "RDP1400"
                AppForm = New frmRDO1201_OperatorProduksi
            Case "R200130"
                AppForm = New frmRPT200_130_CircularLoom
            Case "R200140"
                AppForm = New frmRPT200_140_AnalisaProduksiLoomByMesin
            Case "R200180"
                AppForm = New frmRPTSAP_LaporanFloorLoom
            Case "R200150"
                AppForm = New frmRPT200_150_Loom
            Case "R200160"
                AppForm = New frmRPT200_160_Loom
            Case "R200160B"
                AppForm = New frmRPT200_160b_CircularLoom
            Case "R200170"
                AppForm = New frmRPT200_170_AnalisaBerat
            Case "RDP2200"
                AppForm = New frmRPT200_140_AnalisaProduksiLoomByMesin
            Case "RDP2100"
                AppForm = New frmRPT2100_HasilCircularLoom
            Case "R210100"
                AppForm = New frmRPT210_100_GudangRoll
            Case "R210110"
                AppForm = New frmRPT210_110_StockRollGudangRoll
            Case "R210120"
                AppForm = New frmRPT210_120_TransferGudangRoll
            Case "R210190"
                AppForm = New frmRPT210_190_GudangRoll
            Case "R500110"
                AppForm = New frmRPT500_110_PemakaianBahanBmf
            Case "R500100"
                AppForm = New frmRPT500_100_BenangMultifilament
            Case "R500160"
                AppForm = New frmRPT500_160_Bmf
            Case "R320100"
                AppForm = New frmRPT320_100_PrintingRoll
            Case "R320120"
                AppForm = New frmRPT320_120_PemakaianBPPrintingRoll
            Case "R320110"
                AppForm = New frmRPT320_110_StockRollPrinting
            Case "R320150"
                AppForm = New frmRPT320_150_PrintingRoll
            Case "R321100"
                AppForm = New frmRPT321_100_Cutting
            Case "R321110"
                AppForm = New frmRPT321_110_StockHasilCutting_1
            Case "R321150"
                AppForm = New frmRPT321_150_Cutting
            Case "R322100"
                AppForm = New frmRPT322_100_Jahit
            Case "R322110"
                AppForm = New frmRPT322_110_StockHasilJahit
            Case "R322150"
                AppForm = New frmRPT322_150_Jahit
            Case "R323100"
                AppForm = New frmRPT323_100_PrintingPcs
            Case "R323110"
                AppForm = New frmRPT323_110_StockHasilPrintingPcs
            Case "R324100"
                AppForm = New frmRPT324_100_Inner
            Case "R324110"
                AppForm = New frmRPT324_110_StockHasilInner
            Case "R329100"
                AppForm = New frmRPT329_100_PackingKarung
            Case "R329110"
                AppForm = New frmRPT329_110_StockBallKarung
            Case "R329150"
                AppForm = New frmRPT329_150_PackingKarung
            Case "R329120"
                AppForm = New frmRPT329_120_DaftarItem
            Case "R319110"
                AppForm = New frmRPT319_110_StockBallCementBag
            Case "R319100"
                AppForm = New frmRPT319_100_PackingCementBag
            Case "R312110"
                AppForm = New frmRPT312_110_StockCementBag
            Case "R400100"
                AppForm = New frmRPT400_100_PenyerahanHasilProduksi
            Case "R312100"
                AppForm = New frmRPT312_100_HasilCementBag
            Case "R311110"
                AppForm = New frmRPT311_110_StockRollSlitting
            Case "R310110"
                AppForm = New frmRPT310_110_StockRollLaminating
            Case "R311120"
                AppForm = New frmRPT311_120_Slitting_AnalisaRollKeRoll
            Case "R311150"
                AppForm = New frmRPT311_150_Slitting
            Case "R319150"
                AppForm = New frmRPT319_150_PackingCementBag
            Case "R310150"
                AppForm = New frmRPT310_150_Laminasi
            Case "R312150"
                AppForm = New frmRPT312_150_CementBag
            Case "R312120"
                AppForm = New frmRPT312_120_BahanRollCementBag
            Case "R310120"
                AppForm = New frmRPT310_120_PemakaianBPLaminating
            Case "R311100"
                AppForm = New frmRPT311_100_Slitting
            Case "R312130"
                AppForm = New frmRPT312_130_HasilCementBag
            Case "R310100"
                AppForm = New frmRPT310_100_Laminating
            Case "R600110"
                AppForm = New frmRPT600_110_GudangAfval
            Case "R610100"
                AppForm = New frmRPT610100_Recycle
            Case "R600100"
                AppForm = New frmRPT600_100_GudangAfval
            Case "R210130"
                AppForm = New frmRPT210_130_GudangRoll
            Case "IC10001"
                AppForm = New frmRPT_MonitoringMesinPPIC
            Case "IC10002"
                AppForm = New frmRPT7000_Monitoring_WO_ListPPIC
            Case "R100140"
                AppForm = New frmRPT100_140_Extruder
            Case "IC10003"
                AppForm = New frmRPTPPIC_Backorder_1
            Case "CACC001"
                AppForm = New frmListBomWO
            Case "CACC002"
                AppForm = New frmRPT800_150_CostAccounting
            Case "CACC003"
                AppForm = New frmRPT800_150_CostAccountingWIP
            Case "R310131"
                AppForm = New frmRPT310_130_Laminating_AnalisaRollKeRoll
            Case "AN001"
                AppForm = New frmRPT320_130_PrintingRoll_AnalisaRollKeRoll
            Case "AN002"
                AppForm = New frmRPT321_121_Cutting_AnalisaRollKePcs
            Case "GI001"
                AppForm = New frmRPT410_100_ReturHasilProduksi_
            Case "GI002"
                AppForm = New frmRPT400_200_PenyerahanHasilProduksi
            Case "CACC004"
                AppForm = New frmRPT800_120_CostAccounting
            Case "CACC005"
                AppForm = New frmRPT800_121_CostAccounting
            Case "EXT001"
                AppForm = New frmRPT1300_Extruder
            Case "BMF001"
                AppForm = New frmRPT1300_BMF
            Case "BMF002"
                AppForm = New frmRPT500_130_StockHasilBenangMultifilament_FloorBMF
            Case "GI003"
                AppForm = New frmRPT500_130_StockHasilBenangMultifilament
            Case "CACC006"
                AppForm = New frmRPTHPPCostAcoounting
            Case "INN001"
                AppForm = New frmRPTPemakaianBahanInner
            Case "AFV001"
                AppForm = New frmRPT1300_Recycle
            Case "IC10004"
                AppForm = New frmRPTPPIC_MonitoringOP
            Case "R110240"
                AppForm = New frmRPT110_100_GudangBenang_Ret
            Case "IC10005"
                AppForm = New frmRPT_Sinkronisasi
            Case "GBN0001"
                AppForm = New frmRPTTransformBenang
            Case "CB001"
                AppForm = New frmRPTAnalisaRolltoPCSCemmentBag
            Case "GBN0002"
                AppForm = New frmRPTKartuStockSupportPPIC
            Case "AN003"
                AppForm = New FrmRpt_BSvsAfval
            Case "CACC007"
                AppForm = New FrmRpt_StockOpname
            Case "CACC008"
                AppForm = New frmRPT_cosacc_SAPVsConsole
            Case "CACC009"
                AppForm = New frmListBom
            Case "BL001"
                AppForm = New frmRPTTransformBalltoPcs
            Case "BL002"
                AppForm = New frmStockBallpress
            Case "EXT002"
                AppForm = New frmRPT00101_HasilExtruder

        End Select
        Form = AppForm

    End Function

End Class