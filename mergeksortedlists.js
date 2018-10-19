function mergeKLists (lists){
    return partition(lists, 0, lists.length - 1);
}

function partition(lists, s, e){
    if(s === e) return lists[s];
    if(s < e){
        let q = Math.floor((s + e) / 2);
        let l1 = partition(lists, s, q);
        let l2 = partition(lists, q + 1, e);
        return merge(l1, l2);
    }else{
        return null;
    }
}

function merge(l1, l2){
    if(l1 === null) return l2;
    if(l2 === null) return l1;
    if(l1.val < l2.val){
        l1.next = merge(l1.next,l2);
        return l1;
    }else {
        l2.next = merge(l1,l2.next);
        return l2;
    }
}