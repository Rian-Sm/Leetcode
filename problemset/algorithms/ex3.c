// 2. Add Two Numbers

/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* addTwoNumbers(struct ListNode* l1, struct ListNode* l2) {
    struct ListNode *initNode = (struct ListNode*) malloc(sizeof(struct ListNode));
    struct ListNode *headNode = initNode;
    headNode->val = 0;
    headNode->next = NULL;

    while (l1 || l2){
        int sum = headNode->val;

        if(l1){
            sum += l1->val;
            l1 = l1->next;
        }

        if(l2){
            sum += l2->val;
            l2 = l2->next;
        }

        headNode->val = sum % 10;

        headNode->next = (struct ListNode*) malloc(sizeof(struct ListNode));
        headNode->next->next = NULL;
        headNode->next->val = sum/10;

        if(!l1 && !l2 && headNode->next->val == 0){
             headNode->next = NULL;
        } else{
            headNode = headNode->next;
        }
    }
    return initNode;
}
