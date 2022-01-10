'''
1- Bir listeyi düzleştiren (flatten) fonksiyon yazın. Elemanları birden çok katmanlı listelerden ([[3],2] gibi) oluşabileceği gibi, non-scalar verilerden de oluşabilir. Örnek olarak:

input: [[1,'a',['cat'],2],[[[3]],'dog'],4,5]

output: [1,'a','cat',2,3,'dog',4,5]
'''
def flat(m_flat):
    for i in m_flat:
        if isinstance(i, list):
            yield from flat(i)
        else:
            yield i

m = [[1, 'a', ['cat'], 2], [[[3]], 'dog'], 4, 5]
m_flat = [a for a in flat(m)]

print(m_flat)

#----------------------------------------------------------------------------------------

'''
2- Verilen listenin içindeki elemanları tersine döndüren bir fonksiyon yazın. Eğer listenin içindeki elemanlar da liste içeriyorsa onların elemanlarını da tersine döndürün. Örnek olarak:

input: [[1, 2], [3, 4], [5, 6, 7]]

output: [[[7, 6, 5], [4, 3], [2, 1]]
'''

numbers = [[1, 2], [3, 4], [5, 6, 7]]
for i in numbers:
    i.reverse()
numbers.reverse()

print(numbers)