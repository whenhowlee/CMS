﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using YangKai.BlogEngine.Modules.PostModule.Objects;
using YangKai.BlogEngine.ServiceProxy;

namespace YangKai.BlogEngine.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        [ActionName("index")]
        public ActionResult Index()
        {
            var list = temp.Replace(" ", string.Empty).Split('•');
            var r = new Random();
            return View((object)list[r.Next(0, list.Length - 1)]);
        }

        [ActionName("layout-header")]
        public PartialViewResult Nav()
        {
            var channels = QueryFactory.Instance.Post.FindAllByNotDeletion();
            return PartialView(channels);
        }

        private string temp =
            "回老家结婚 • 贫乳是稀有价值 • 都是世界的错 • 都是时臣的错 • 你们都是我的翅膀 • 呀啦那一卡(不来一发么) • 就算是神也杀给你看 • 大丈夫萌大奶 • 可爱即正义 • 小学生真是太棒了 • 膝盖中了一箭 • 因为年轻而犯下的错 • 还有马桶盖子 • 很了不起的大象先生吧 • 这是何等的灵压啊 • 我已经看到结局了 • 不要扶他 • 这么可爱一定是男孩子 • 前方高能反应 • 战斗力只有5的渣渣 • 连我爸爸都没有打过我 • 这时只要微笑就可以了 • 我要成为新世界的卡密 • 梓喵打酱油 • 哥哥借我辞典 • 真是肤浅 • 和我签订契约，成为魔法少女吧 • 正面上我啊 • 我的妹妹不可能这么可爱 • 在妹妹的房间用妹妹的电脑玩对妹妹耍流氓的游戏 • 超好玩的!你有什么不满吗 • 你们两个，干脆交往算啦 • 不是萝莉控，是女权主义者 • 想死一次吗 • 去死两次 • 敌羞吾去脱她衣系列 • 阿姨洗铁路 • 绝望了，我对这个○○的世界绝望了 • 突破天际 • 你已经死了 • 计划通 • 你不是还有生命吗? • 德国的科学技术是世界第一 • 我很好奇 • 你从什么时候开始产生了○○○○的错觉? • 只要杀了OO我随便你搞 • 写作○○读作×× • 我曾经把你当做过自慰对象 • 心叶，你一定不懂吧 • 你为什么不问问神奇海螺呢 • 蛋糕是个谎言 • 就算是○○，只要有爱就没问题 • 好讨厌，○○一直停不下来 • 已经没什么好害怕的了 • 你还记得自己是男的 • 这是禁止事项 • 啊哈哈，佐佑理不知道 • 胸部什么的，明明只是装饰 • 一个人要走多少路，才能让别人承认他是个爷们儿 • 亚瑟王不懂人心 • 任性可是女孩子的天性呢 • 一旦接受了这种设定 • 这虽然是○○，但可不是○○○○ • 酿了你哦 • 真讨厌，不快点辗碎的话 • 今天的风儿好喧嚣啊 • 不是○○，是○! • 你这男人到底有没有蛋蛋啊 • 一大波僵尸正在接近 • 就这样插进去就行了 • 这个男人，有两把刷子 • 我考虑了一下，还是无法接受啊！ • 你的爱还不够啊! • 男人的本能真丑陋 • ○○又死了！真没人性！ • 虽然我可爱又迷人，但我会招来死亡 • 少女祈祷中 • 不作死就不会死，为什么不明白! • 你们这是自寻死路 • 只有○○知道的世界 • 不被发现就不算犯罪哦！ • 画个圈圈诅咒你 • 前略，天国的oo君 • 骑乘位老师 • 艺术就是爆炸 • 人被杀就会死 • 爱酱大胜利 • 爱酱大失败 • 头脑稍微冷静一下吧 • 男人变态有什么错 • 节操掉尽人清爽 • 那一天，人类终于想起了○○的恐怖 • 进击的○○ • 在虚构的故事当中寻求真实感的人脑袋一定有问题 • 诸君，我喜欢○○ • 其实我是你爸爸 • 夫人窝来送水了 • 萝莉有三好，身娇腰柔易推倒 • 索尼罪大滔天，搞到百姓怨声载道 • 躺着也中枪 • 一个能打的都没有 • 因为很重要所以说了两遍 • 你才○○，你们全家都○○ • 我整个人都○○了 • 元芳你怎么看 • 快到碗里来 • 战个痛快 • 小火把在闲逛 • 放开那个○○ • 我有知识我自豪 • 道歉时露出胸部是常识 • 勇士喜欢巨乳有什么错! • 哪里不会点哪里 • 妈妈再也不用担心我的○○ • 把我血加住，我有盾墙 • 嘎嘣脆鸡肉味 • 只要出问题C4都能搞定 • ○○是什么，能吃吗 • 警察叔叔，就是这个人！ • 抓住一只野生的 • 天降软妹 • 自古红蓝出CP • 只要可爱就算是男孩子也没关系 • 粉红的切开来里面都是黑的 • 画个软妹子硬说是男的 • 萌音绕梁，三日不绝 • 有个能干的妹妹真好 • 亲妹妹不如干妹妹 • 记得关好门 • 一对百合一对基，剩下一个是苦逼 • 技术宅拯救世界 • 蝉在叫人坏掉 • 三个人结婚吧 • 性别不同怎么谈恋爱 • ○○什么的最讨厌了 • ○○很萌的，你们不要黑她 • 此生无悔入东方，来世愿生幻想乡 • ○○如同大小姐的威严一样伟岸 • 我就是叫紫妈怎么了 • ○○必须死 • 如果○○，就是神作了 • 不要在意细节 • 官方逼死同人 • 总有一天你们会看着我画的东西撸 • 我裤子都脱了你就让我看这个? • 打土豪，分手办 • 地球君又杯具了 • 娶妻当如樱庭葵，生女当如泉此方 • 诚哥死的早 • 胸不平何以平天下，乳不巨何以聚人心 • 我们不用很麻烦很累就可以成佛 • 祝天下有情人终成兄妹 • 这部动画抄袭了○○ • 大葱插菊花治疗感冒 • 哈士奇与王守义 • 读书顶个鸟用 • 吃饭睡觉虐太一，不虐太一不ED • 小鸟游家要小心一个叫X太的男人 • 只要还活着，就算是神也吃给你看！ • 世界已完蛋 • 快来搞死那只激萌的萝莉 • 新世纪的萝莉控 • 砍了那只鸭 • 吃饭睡觉打○○ • 一定是我打开的方式不对 • 天顶星科技 • 你知道的太多了 • 你们都是坏人 • 我为自己代言/我喂自己袋盐 • 这不科学 • 霸气侧漏 • 纯爷们从不回头看爆炸 • 这是人干的事吗 • 虽不明，但觉厉 • 信息量很大 • 眼睛里进了○○ • 不○○不舒服斯基 • ○○人民发来贺电 • ○○你好，○○再见 • 普通○○，文艺○○和2b○○ • ○○只能帮你到这儿了 • 哥哥让开!这样我杀不了那家伙! • 有一种杀了他就能升级的感觉 • 杀了他就能满级 • 真当自己大小姐 • 过去的○○弱爆了 • 一直被○○，从未被超越 • 我们中出了叛徒 • 我的○○已经饥渴难耐了 • 我不需要性爱，因为政府每天都在强奸我 • 正确饲养你的方法 • 烧死那对异性恋 • 哈哈哈哈，你看看你! • 终结此串 • 一曲忠诚的赞歌 • 天诛八尺，还我公图 • 简直就是狂欢一样 • 你们不是要民主，要自由吗？ • 八点二十发 • 你在大声什么啦 • 自古二楼出○○ • 不服来辩 • 我跟你讲，○○ㄋㄟㄋㄟ，赞 • ○○望着自己贫瘠的胸部说道 • 楼主好人一生平安 • 退微博保智商 • 撸多视觉模糊 • 发图不发种，菊花万人捅 • 我的字典里没有○○ • 你不会○○会死吗 • 有奇怪的东西混进去了 • 我们的同志遍布五湖四海 • 我们的同志已经打入敌人内部 • 认真你就输了 • 壮哉我大○○ • 又黑我大○○ • 为什么伤害我们脖子 • 我家的○○ • ○○是我○○ • 没图你说个○○ • 醒醒吧，那是你○○ • 看到○○我就进来了 • 满状态原地复活 • 我看过报道，这个人后来死了 • ○我一脸 • 求○○视角 • 求○○ • ○○○，忍够了 • 报复社会 • ○○是什么，能吃吗 • 首先，你得有个○○ • 终结此帖 • 无力吐槽 • 羡慕嫉妒恨 • 感觉不会再爱了 • 不是○○不幸福 • 可以帮我打马赛克吗 • 我们来削弱德系吧 • 我们来削下刀妹吧 • 我平胸我骄傲，我为国家省布料 • 有什么东西要觉醒了 • 晒妹十天 • 意念打字中 • 我去年买了个表 • 我和他谈笑风生 • 图样图森破 • 根据相关法律法规和政策，部分搜索结果未予显示 • 在我印象中○○是很好的选择 • 兵库北的微笑 • ○○黑丧心病狂 • 论○○的××× • 宅男费纸，宅女费电 • 你们感受一下 • 专注○○三十年 • 让他明白";
    }
}