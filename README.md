<p align="center">
  <img width="240" alt="Maditp 2.0" src="https://github.com/maditp/MADITP2.0/blob/master/MADITP2.0/Resources/logo%20MADITP%202.png?raw=true">
</p>

# MADITP2.0

### Our Tasklist
- [Maditp 2.0 Tasklist](https://docs.google.com/spreadsheets/d/14vibg-NvIYpqkmFZREOSjkJkDqlrYyS9QRBHGsMZDXs/edit#gid=4777971)

### QC Tasklist
- https://docs.google.com/spreadsheets/d/1HO6tDTomgiivHTSfIuVNhOIE2qSV6FXyWIqu1OPtGCM/edit#gid=0

### Application Structure 
| Package Name  | Description |
| ------------- | ------------- |
| BussinessLogic (BL) | Adalah representasi dari table sebuat fiture, berisi setter getter. |
| DataAccess (DA) | Semua yang berhubungan dengan database di tulis disini, tidak direkomendasikan menulis validasi, atau operasi logika di layer ini. |
| ApplicationLogic (AL) | Validasi, perhitungan, dan operasi logika ditulis disini, AL meneruskan request ke DA. Recommended untuk menggunakan layer ini di form. |
| UserInterface (UI) | Form disimpan pada layer ini. |

### Development Flow 
1. Setiap mengerjakan fitur baru, selalu pastikan local master branch uptodate dengan remote master branch. 
2. Setiap mengerjakan fitur baru, buat branch baru dari master eg : `git checkout -b namamu_NamaFeatureMu`. 
3. Buat pull request (PR) untuk merge branch fitur mu ke master.
