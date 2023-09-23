---
title: bash
---
# キー操作
- C-w: 直前の単語をひとつ削除
- cd -: 移動する前のディレクトリに戻る

# 条件式
- 数値を比較: [[ $num -gt 5 && $num -lt 10 ]] && echo num is in range.
- 数値が等しい: [[ $num -eq 10 || $num -eq 5]] && echo equal.
- 文字列が一致: [[ "xxx" = "xxx" ]] && echo matched.
- 正規表現のマッチ: [[ "abcde" =~ ^abc ]] && echo RE matched.
- 変数が空でない: [[ -n $X ]] && echo not empty.

# ファイルやディレクトリの確認
- パスの存在:  [[ -e ./test ]] && echo path exists.
- ファイルの存在:  [[ -f ./test ]] && echo file exists.
- ディレクトリの存在: if [[ -d ./test ]] && echo directory exists.
- リンクの存在: [[ -L ./test ]] && echo link exists.
- 空ファイルではないか: [[ -s ./test ]] && echo no empty.
- 書込可能か: [[ -w ./test ]] && echo readable.
- 実行可能か: [[ -x ./test ]] && echo writable. 

# ファイル名の操作
- 拡張子の差し替え: cp -p file.txt{,.bk}

# 数字
- 連番を生成: echo {1..10}
- ゼロ埋めで連番を生成: seq -w 10

# 計算
- echo $((1 + 1))

# 外部コマンドの活用
- ランダムな文字列を生成: openssl rand -base64 10
- ふたつのファイルをソートした上で比較: diff <(sort a.txt) <(sort b.txt)
- 日付を含むファイル名を作る: $(date +%Y%m%d).log
- あるファイルのフルパスを得る: readlink -e commit-workspace
- 行をランダムに並べ替える: seq 10 | shuf

